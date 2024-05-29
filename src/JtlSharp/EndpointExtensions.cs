using System.IO.Compression;
using System.Text.Json;
using System.Text.Json.Nodes;
using Jtl.Connector.Core.Model;
using JtlSharp.Converter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace JtlSharp;

public static class EndpointExtensions
{
    private static readonly JsonSerializerOptions _options = new JsonSerializerOptions()
    {
        Converters =
        {
            new IdentityConverter(),
            new DateTimeOffsetConverter(),
            new ProductStockLevelConverter()
        }
    };
    
    private static T? Read<T>(this JtlRpc rpc) where T : class
    {
        return rpc.@params is {} node ? node.Deserialize<T>(_options) : null;
    }

    private static async Task<object> Process(this Feature<AbstractImage> feature, JtlRpc rpc, ZipArchive archive)
    {
        return rpc.method.Split('.').Last() switch
        {
            "push" => await rpc.Read<IReadOnlyCollection<AbstractImage>>()
                .ToAsyncEnumerable()
                .SelectAwait(async (a, t) => await feature.Push(new ZipImage(a, archive!)))
                .ToListAsync(),
            _ => await feature.Process(rpc)
        };
    }

    private static async Task<object> Process<T>(this Feature<T> feature, JtlRpc rpc) where T : AbstractModel
    {
        return rpc.method.Split('.').Last() switch
        {
            "pull" => await feature.Pull(rpc.Read<QueryFilter>()).ToListAsync(),
            "push" => await rpc.Read<IReadOnlyCollection<T>>()
                .ToAsyncEnumerable()
                .SelectAwait(async (a, t) => await feature.Push(a))
                .ToListAsync(),
            "delete" => await feature.Delete<T>(rpc),
            "statistic" => new
            {
                available = await feature.Statistics(),
                controllerName = typeof(T).Name
            },
            _ => throw new InvalidOperationException("Method not found: " + rpc.method)
        };
    }

    private static async Task<JsonNode> Delete<T>(this Feature<T> feature, JtlRpc rpc) where T : AbstractModel
    {
        var input = rpc.Read<IReadOnlyCollection<AbstractIdentity>>();
        await feature.Delete(input.Select(b => b.id).ToList());
        return rpc.@params;
    }
    
    public static IEndpointRouteBuilder UseJtl<T>(this IEndpointRouteBuilder app, string token, string basePath = "/jtl")
        where T : IJtlService
    {
        app
            .MapPost(basePath, async context =>
            {
                var logger = context.RequestServices.GetRequiredService<ILogger<IJtlService>>();
                
                var form = await context.Request.ReadFormAsync();
                if (!form.TryGetValue("jtlrpc", out var jtlrpc))
                    throw new InvalidOperationException("jtlrpc not found");
                
                logger.LogTrace("JtlRequest: {jtlrpc}", jtlrpc);

                var rpc = JsonSerializer.Deserialize<JtlRpc>(jtlrpc);
                if (rpc is null)
                    throw new InvalidOperationException("Invalid jtlrpc");
                
                try
                {
                    object result = null;
                    
                    if (!form.TryGetValue("jtlauth", out var jtlauth)) {
                        switch (rpc.method)
                        {
                            case "connector.identify":
                                var service2 = ActivatorUtilities.CreateInstance<T>(context.RequestServices);

                                result = await service2.Identify();
                            break;
                            case "core.connector.auth":
                                var authentication = rpc.Read<Authentication>();
                                if (token != authentication.token)
                                    throw new InvalidOperationException("Authentication failed.");

                                result = new Session
                                {
                                    sessionId = Guid.NewGuid().ToString(),
                                    lifetime = 3600
                                };
                            break;
                                //throw new InvalidOperationException("Not authenticated for action: " + rpc.method);
                        }
                    } 
                    
                    if (result is null) {
                        // token control
                        
                        await using var zipFileStream =  form.Files.Count > 0 ? form.Files[0].OpenReadStream() : null;
                        using var zipFile = zipFileStream is null ? null : new ZipArchive(zipFileStream);
                        
                        var service = ActivatorUtilities.CreateInstance<T>(context.RequestServices);
                        
                        var features = service.GetFeatures();
                        
                        result = rpc.method.ToLowerInvariant() switch
                        {
                            "core.connector.features" => features,
                            "core.connector.ack" => await features.Entities.ProcessAck(rpc.Read<Ack>()!),
                            "core.connector.init" => true,
                            "connector.finish" => true,
                            "connector.identify" => await service.Identify(),
                            "core.linker.clear" => rpc?.Read<Ack>() is {} ack
                                ? await features.Entities.ProcessAck(ack, true)
                                : await service.Clear(),
                            
                            "global_data.pull" or "globaldata.pull" => Enumerable.Repeat(new GlobalData()
                            {
                                currencies = features.Entities.Currency?.Pull is null ? [] : await features.Entities.Currency.Pull(null).ToListAsync(),
                                languages = features.Entities.Language?.Pull is null ? [] : await features.Entities.Language.Pull(null).ToListAsync(),
                                warehouses = features.Entities.Warehouse?.Pull is null ? [] : await features.Entities.Warehouse.Pull(null).ToListAsync(),
                                productTypes = features.Entities.ProductType?.Pull is null ? [] : await features.Entities.ProductType.Pull(null).ToListAsync(),
                                shippingClasses = features.Entities.ShippingClass?.Pull is null ? [] : await features.Entities.ShippingClass.Pull(null).ToListAsync(),
                                shippingMethods = features.Entities.ShippingMethod?.Pull is null ? [] : await features.Entities.ShippingMethod.Pull(null).ToListAsync(),
                                crossSellingGroups = features.Entities.CrossSellingGroup?.Pull is null ? [] : await features.Entities.CrossSellingGroup.Pull(null).ToListAsync(),
                                taxRates = features.Entities.TaxRate?.Pull is null ? [] : await features.Entities.TaxRate.Pull(null).ToListAsync(),
                                units = features.Entities.Unit?.Pull is null ? [] : await features.Entities.Unit.Pull(null).ToListAsync(),
                                configGroups = features.Entities.ConfigGroup?.Pull is null ? [] : await features.Entities.ConfigGroup.Pull(null).ToListAsync(),
                                configItems = features.Entities.ConfigItem?.Pull is null ? [] : await features.Entities.ConfigItem.Pull(null).ToListAsync(),
                                customerGroups = features.Entities.CustomerGroup?.Pull is null ? [] : await features.Entities.CustomerGroup.Pull(null).ToListAsync(),
                                measurementUnits = features.Entities.MeasurementUnit?.Pull is null ? [] : await features.Entities.MeasurementUnit.Pull(null).ToListAsync(),
                            }, 1),

                            var s when s.StartsWith("product.") 
                                => await features.Entities.Product.Process(rpc),
                            var s when s.StartsWith("category.") 
                                => await features.Entities.Category.Process(rpc),
                            var s when s.StartsWith("manufacturer.") 
                                => await features.Entities.Manufacturer.Process(rpc),
                            var s when s.StartsWith("currency.") 
                                => await features.Entities.Currency.Process(rpc),
                            var s when s.StartsWith("customer.") 
                                => await features.Entities.Customer.Process(rpc),
                            var s when s.StartsWith("customergroup.") 
                                => await features.Entities.CustomerGroup.Process(rpc),
                            var s when s.StartsWith("customerorder.")
                                => await features.Entities.CustomerOrder.Process(rpc),
                            var s when s.StartsWith("deliverynote.") 
                                => await features.Entities.DeliveryNote.Process(rpc),
                            //var s when s.StartsWith("fileDownload.") 
                            //    => await features.Entities.FileDownload.Process(rpc),
                            var s when s.StartsWith("fileupload.") 
                                => await features.Entities.FileUpload.Process(rpc),
                            var s when s.StartsWith("image.") 
                                => await features.Entities.Image.Process(rpc, zipFile),
                            var s when s.StartsWith("language.") 
                                => await features.Entities.Language.Process(rpc),
                            var s when s.StartsWith("measurementunit.") 
                                => await features.Entities.MeasurementUnit.Process(rpc),
                            var s when s.StartsWith("mediafile.") 
                                => await features.Entities.MediaFile.Process(rpc),
                            var s when s.StartsWith("partslist.") 
                                => await features.Entities.PartsList.Process(rpc),
                            var s when s.StartsWith("payment.") 
                                => await features.Entities.Payment.Process(rpc),
                            //var s when s.StartsWith("productprice.") 
                            //    => await features.Entities.ProductPrice.Process(rpc),
                            //var s when s.StartsWith("productstocklevel.") 
                            //    => await features.Entities.ProductStockLevel.Process(rpc),
                            var s when s.StartsWith("specific.") 
                                => await features.Entities.Specific.Process(rpc),
                            var s when s.StartsWith("statuschange.") 
                                => await features.Entities.StatusChange.Process(rpc),
                            var s when s.StartsWith("taxclass.") 
                                => await features.Entities.TaxClass.Process(rpc),
                            var s when s.StartsWith("taxrate.") 
                                => await features.Entities.TaxRate.Process(rpc),
                            var s when s.StartsWith("taxzone.") 
                                => await features.Entities.TaxZone.Process(rpc),
                            var s when s.StartsWith("unit.") 
                                => await features.Entities.Unit.Process(rpc),
                            var s when s.StartsWith("warehouse.") 
                                => await features.Entities.Warehouse.Process(rpc),
                            
                            var s when s.StartsWith("product_price.") 
                                => await features.Entities.ProductPrice.Process(rpc),

                            var s when s.StartsWith("product_stock_level.") 
                                => await features.Entities.ProductStockLevel.Process(rpc),
                            
                            var s when s.StartsWith("crossselling.") || s.StartsWith("cross_selling.")
                                => await features.Entities.CrossSelling.Process(rpc),

                            _ => throw new InvalidOperationException("Method not found: " + rpc.method)
                        };
                    }

                    var jtlResponseObj = new JtlRpcResult<object>
                    {
                        jtlrpc = "2.0",
                        id = rpc.id,
                        result = result
                    };

                    if (logger.IsEnabled(LogLevel.Trace))
                    {
                        var resp = JsonSerializer.Serialize(jtlResponseObj, _options);
                        logger.LogTrace("JtlResponse: {resp}", resp);
                    }
                    
                    await context.Response.WriteAsJsonAsync(jtlResponseObj, _options);
                }
                catch (Exception e)
                {
                    logger.LogError(e, "Error processing request");
                    
                    await context.Response.WriteAsJsonAsync(new JtlRpcErrorResult
                    {
                        jtlrpc = "2.0",
                        id = rpc.id,
                        error = new JtlRpcError()
                        {
                            code = 790,
                            message = e.Message
                        }
                    }, _options);
                }
            })
            .ExcludeFromDescription();

        return app;
    }
}
