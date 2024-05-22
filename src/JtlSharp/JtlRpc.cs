using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public record JtlRpc
{
    public string method { get; init; }
    
    public JsonNode? @params { get; init; }
    
    public string id { get; init; }
}

public record JtlRpcResult
{
    public string jtlrpc { get; init; }
    
    public string id { get; init; }
}

public record JtlRpcErrorResult : JtlRpcResult
{
    public int? result => null;

    public JtlRpcError error { get; init; }
}

public record JtlRpcResult<T> : JtlRpcResult
{
    public T result { get; init; }

    public JtlRpcError? error => null;
}

public record JtlRpcError
{
    public int code { get; init; }

    public string message { get; init; }

    public string data { get; init; }
}
