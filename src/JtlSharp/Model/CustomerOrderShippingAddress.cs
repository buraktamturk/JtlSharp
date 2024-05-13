namespace Jtl.Connector.Core.Model;

public record CustomerOrderShippingAddress : AbstractOrderAddress
{
    /// <summary>
    /// Identity Reference to customer
    /// </summary>
    public Identity? customerId { get; init; }

}

