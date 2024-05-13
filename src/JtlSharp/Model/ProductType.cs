namespace Jtl.Connector.Core.Model;

public record ProductType : AbstractIdentity
{
    /// <summary>
    /// string Optional (internal) product type name
    /// </summary>
    public string? name { get; init; }

}

