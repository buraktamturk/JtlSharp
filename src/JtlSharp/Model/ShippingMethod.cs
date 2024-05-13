namespace Jtl.Connector.Core.Model;

public record ShippingMethod : AbstractIdentity
{
    /// <summary>
    /// string
    /// </summary>
    public string? name { get; init; }

}

