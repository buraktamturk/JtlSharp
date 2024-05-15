﻿using System.IO.Compression;
using System.Text.Json;
using Jtl.Connector.Core.Model;
using JtlSharp.Converter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

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
                var form = await context.Request.ReadFormAsync();
                if (!form.TryGetValue("jtlrpc", out var jtlrpc))
                    throw new InvalidOperationException("jtlrpc not found");

                var rpc = JsonSerializer.Deserialize<JtlRpc>(jtlrpc);
                if (rpc is null)
                    throw new InvalidOperationException("Invalid jtlrpc");

                try
                {
                    if (!form.TryGetValue("jtlauth", out var jtlauth)) {
                        switch (rpc.method)
                        {
                            case "core.connector.auth":
                                var authentication = rpc.Read<Authentication>();
                                if (token != authentication.token)
                                    throw new InvalidOperationException("Authentication failed.");
                                
                                await context.Response.WriteAsJsonAsync(new JtlRpcResult<Session>
                                {
                                    jtlrpc = "2.0",
                                    id = rpc.id,
                                    result = new Session
                                    {
                                        sessionId = Guid.NewGuid().ToString(),
                                        lifetime = 3600
                                    }
                                });

                                return;
                            default:
                                throw new InvalidOperationException("Not authenticated for action: " + rpc.method);
                        }
                    }
                    
                    // token control

                    await using var zipFileStream =  form.Files.Count > 0 ? form.Files[0].OpenReadStream() : null;
                    using var zipFile = zipFileStream is null ? null : new ZipArchive(zipFileStream);
                    
                    var service = ActivatorUtilities.CreateInstance<T>(context.RequestServices);
                    
                    var features = service.GetFeatures();
                    
                    var result = rpc.method switch
                    {
                        "core.connector.features" => features,
                        "core.connector.ack" => await features.Entities.ProcessAck(rpc.Read<Ack>()!),
                        "core.connector.init" => true,
                        "connector.finish" => true,
                        "connector.identify" => await service.Identify(),
                        "core.linker.clear" => rpc?.Read<Ack>() is {} ack
                            ? await features.Entities.ProcessAck(ack, true)
                            : await service.Clear(),

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
                    
                    await context.Response.WriteAsJsonAsync(new JtlRpcResult<object>
                    {
                        jtlrpc = "2.0",
                        id = rpc.id,
                        result = result
                    }, _options);
                }
                catch (Exception e)
                {
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
