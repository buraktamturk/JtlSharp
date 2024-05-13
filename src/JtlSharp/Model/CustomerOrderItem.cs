namespace Jtl.Connector.Core.Model;

public record CustomerOrderItem : AbstractIdentity
{
    /// <summary>
    /// Identity Optional reference to configItemId (if item is part of a configurable item
    /// </summary>
    public Identity? configItemId { get; init; }

    /// <summary>
    /// Identity Reference to product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// string Order item name
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// double Price (net
    /// </summary>
    public decimal? price { get; init; }

    /// <summary>
    /// double Price (gross
    /// </summary>
    public decimal? priceGross { get; init; }

    /// <summary>
    /// double Quantity purchased
    /// </summary>
    public decimal? quantity { get; init; }

    /// <summary>
    /// string Stock keeping Unit (unique item identifier
    /// </summary>
    public string? sku { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? type { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? note { get; init; }

    /// <summary>
    /// string Optional unique Hashsum (if item is part of configurable item
    /// </summary>
    public string? unique { get; init; }

    /// <summary>
    /// double Value added tax
    /// </summary>
    public decimal? vat { get; init; }

    /// <summary>
    /// CustomerOrderItemVariation
    /// </summary>
    public IReadOnlyCollection<CustomerOrderItemVariation>? variations { get; init; }

}

