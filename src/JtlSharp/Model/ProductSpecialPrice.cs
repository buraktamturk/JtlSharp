namespace Jtl.Connector.Core.Model;

public record ProductSpecialPrice : AbstractIdentity
{
    /// <summary>
    /// \DateTimeInterface|null Optional: Activate special price from date
    /// </summary>
    public DateTimeOffset? activeFromDate { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Optional: Special price active until date
    /// </summary>
    public DateTimeOffset? activeUntilDate { get; init; }

    /// <summary>
    /// boolean Optional: Consider activeFrom/activeUntil date range.
     ///              If true, specialPrice will get active from activeFrom-date and will stop after activeUntil-date
    /// </summary>
    public bool? considerDateLimit { get; init; }

    /// <summary>
    /// boolean Optional: Consider stockLimit value.
     ///              If true, specialPrice will be only active until product stockLevel is greater or equal stockLimit
    /// </summary>
    public bool? considerStockLimit { get; init; }

    /// <summary>
    /// boolean Special price is active? Default true, to activate specialPrice.
     ///              Special price can still be inactivated, if date or stock Limitations do not match
    /// </summary>
    public bool? isActive { get; init; }

    /// <summary>
    /// integer Optional: SpecialPrice active until stock level quantity
    /// </summary>
    public int? stockLimit { get; init; }

    /// <summary>
    /// ProductSpecialPriceItem
    /// </summary>
    public IReadOnlyCollection<ProductSpecialPriceItem>? items { get; init; }

}

