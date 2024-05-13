namespace Jtl.Connector.Core.Model;

public record DeliveryNote : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to customerOrder
    /// </summary>
    public Identity? customerOrderId { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Creation date
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// boolean Optional flag for fulfillment. True, if delivery ist fulfilled by someone else
    /// </summary>
    public bool? isFulfillment { get; init; }

    /// <summary>
    /// string Optional text note
    /// </summary>
    public string? note { get; init; }

    /// <summary>
    /// DeliveryNoteItem
    /// </summary>
    public IReadOnlyCollection<DeliveryNoteItem>? items { get; init; }

    /// <summary>
    /// DeliveryNoteTrackingList
    /// </summary>
    public IReadOnlyCollection<DeliveryNoteTrackingList>? trackingLists { get; init; }

}

