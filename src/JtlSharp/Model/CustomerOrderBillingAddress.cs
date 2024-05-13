namespace Jtl.Connector.Core.Model;

public record CustomerOrderBillingAddress : AbstractOrderAddress
{
    /// <summary>
    /// string VAT number (german "USt-ID
    /// </summary>
    public string? vatNumber { get; init; }

}

