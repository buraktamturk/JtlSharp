using System.IO.Compression;
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
                        
                        var s when s.StartsWith("product.")
                            => await features.Entities.Product.Process(rpc),
                        
                        var s when s.StartsWith("category.")
                            => await features.Entities.Category.Process(rpc),
                        
                        var s when s.StartsWith("manufacturer.")
                            => await features.Entities.Manufacturer.Process(rpc),
                        
                        _ => throw new InvalidOperationException("Method not found: " + rpc.method)
                    };
                    
                    await context.Response.WriteAsJsonAsync(new JtlRpcResult<object>
                    {
                        jtlrpc = "2.0",
                        id = rpc.id,
                        result = result
                    });
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
