namespace Jtl.Connector.Core.Model;

public record ShippingClass : AbstractIdentity
{
    /// <summary>
    /// string Optional (internal) Shipping class name
    /// </summary>
    public string? name { get; init; }

}

