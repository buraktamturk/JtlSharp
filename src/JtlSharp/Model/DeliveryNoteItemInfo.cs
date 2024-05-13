namespace Jtl.Connector.Core.Model;

public record DeliveryNoteItemInfo : AbstractModel
{
    /// <summary>
    /// string
    /// </summary>
    public string? batch { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? bestBefore { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? quantity { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? warehouseId { get; init; }

}

