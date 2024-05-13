namespace Jtl.Connector.Core.Model;

public record ProductPrice : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to customerGroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// Identity Reference to customer
    /// </summary>
    public Identity? customerId { get; init; }

    /// <summary>
    /// Identity Reference to product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// ProductPriceItem
    /// </summary>
    public IReadOnlyCollection<ProductPriceItem>? items { get; init; }

}

