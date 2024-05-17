using System.IO.Compression;
using System.Net.Http.Json;
using System.Text.Json;
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
    
    private static async Task<object> Process<T>(this Feature<T> feature, JtlRpc rpc) where T : AbstractModel
    {
        return rpc.method.Split('.').Last() switch
        {
            "pull" => await feature.Pull(rpc.Read<QueryFilter>()).ToListAsync(),
            "push" => await rpc.Read<IReadOnlyCollection<T>>()
                .ToAsyncEnumerable()
                .SelectAwait(async (a, t) => await feature.Push(a))
                .ToListAsync(),
            "statistic" => new
            {
                available = await feature.Statistics(),
                controllerName = typeof(T).Name
            },
            _ => throw new InvalidOperationException("Method not found: " + rpc.method)
        };
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
                    object result;
                    
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
                            default:
                                throw new InvalidOperationException("Not authenticated for action: " + rpc.method);
                        }
                    } else {
                        // token control

                        await using var zipFileStream =  form.Files.Count > 0 ? form.Files[0].OpenReadStream() : null;
                        using var zipFile = zipFileStream is null ? null : new ZipArchive(zipFileStream);
                        
                        var service = ActivatorUtilities.CreateInstance<T>(context.RequestServices);
                        
                        var features = service.GetFeatures();
                        
                        result = rpc.method switch
                        {
                            "core.connector.features" => features,
                            "core.connector.ack" => await features.Entities.ProcessAck(rpc.Read<Ack>()!),
                            "core.connector.init" => true,
                            "connector.finish" => true,
                            "connector.identify" => await service.Identify(),
                            "core.linker.clear" => rpc?.Read<Ack>() is {} ack
                                ? await features.Entities.ProcessAck(ack, true)
                                : await service.Clear(),
                            
                            "global_data.pull" or "globalData.pull" => new GlobalData()
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
                            },

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
                            var s when s.StartsWith("customerGroup.") 
                                => await features.Entities.CustomerGroup.Process(rpc),
                            var s when s.StartsWith("customerOrder.") 
                                => await features.Entities.CustomerOrder.Process(rpc),
                            var s when s.StartsWith("deliveryNote.") 
                                => await features.Entities.DeliveryNote.Process(rpc),
                            var s when s.StartsWith("fileDownload.") 
                                => await features.Entities.FileDownload.Process(rpc),
                            var s when s.StartsWith("fileUpload.") 
                                => await features.Entities.FileUpload.Process(rpc),
                            var s when s.StartsWith("image.") 
                                => await features.Entities.Image.Process(rpc),
                            var s when s.StartsWith("language.") 
                                => await features.Entities.Language.Process(rpc),
                            var s when s.StartsWith("measurementUnit.") 
                                => await features.Entities.MeasurementUnit.Process(rpc),
                            var s when s.StartsWith("mediaFile.") 
                                => await features.Entities.MediaFile.Process(rpc),
                            var s when s.StartsWith("partsList.") 
                                => await features.Entities.PartsList.Process(rpc),
                            var s when s.StartsWith("payment.") 
                                => await features.Entities.Payment.Process(rpc),
                            var s when s.StartsWith("productPrice.") 
                                => await features.Entities.ProductPrice.Process(rpc),
                            var s when s.StartsWith("productStockLevel.") 
                                => await features.Entities.ProductStockLevel.Process(rpc),
                            var s when s.StartsWith("specific.") 
                                => await features.Entities.Specific.Process(rpc),
                            var s when s.StartsWith("statusChange.") 
                                => await features.Entities.StatusChange.Process(rpc),
                            var s when s.StartsWith("taxClass.") 
                                => await features.Entities.TaxClass.Process(rpc),
                            var s when s.StartsWith("taxRate.") 
                                => await features.Entities.TaxRate.Process(rpc),
                            var s when s.StartsWith("taxZone.") 
                                => await features.Entities.TaxZone.Process(rpc),
                            var s when s.StartsWith("unit.") 
                                => await features.Entities.Unit.Process(rpc),
                            var s when s.StartsWith("warehouse.") 
                                => await features.Entities.Warehouse.Process(rpc),

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
                    
                    await context.Response.WriteAsJsonAsync(new JtlRpcResult
                    {
                        jtlrpc = "2.0",
                        id = rpc.id,
                        error = new JtlRpcError()
                        {
                            code = 790,
                            message = e.Message
                        }
                    });
                }
            })
            .ExcludeFromDescription();

        return app;
    }
}
