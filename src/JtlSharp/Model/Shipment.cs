namespace Jtl.Connector.Core.Model;

public record Shipment : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to deliveryNote
    /// </summary>
    public Identity? deliveryNoteId { get; init; }

    /// <summary>
    /// string Carrier name
    /// </summary>
    public string? carrierName { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Creation date
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// string Optional Identcode
    /// </summary>
    public string? identCode { get; init; }

    /// <summary>
    /// string Optional shipment note
    /// </summary>
    public string? note { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? trackingUrl { get; init; }

}

