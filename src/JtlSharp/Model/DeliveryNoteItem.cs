namespace Jtl.Connector.Core.Model;

public record DeliveryNoteItem : AbstractIdentity
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? customerOrderItemId { get; init; }

    /// <summary>
    /// Identity Reference to product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? quantity { get; init; }

    /// <summary>
    /// DeliveryNoteItemInfo
    /// </summary>
    public IReadOnlyCollection<DeliveryNoteItemInfo>? info { get; init; }

}

