namespace Jtl.Connector.Core.Model;

public record Warehouse : AbstractIdentity
{
    /// <summary>
    /// string Warehouse name
    /// </summary>
    public string? name { get; init; }

}

