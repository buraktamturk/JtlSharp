namespace Jtl.Connector.Core.Model;

public record CustomerGroup : AbstractIdentity
{
    /// <summary>
    /// boolean Optional: Show net prices default instead of gross prices
    /// </summary>
    public bool? applyNetPrice { get; init; }

    /// <summary>
    /// double Optional percentual discount on all products. Negative Value means surcharge
    /// </summary>
    public decimal? discount { get; init; }

    /// <summary>
    /// boolean Optional: Flag default customer group
    /// </summary>
    public bool? isDefault { get; init; }

    /// <summary>
    /// CustomerGroupAttr
    /// </summary>
    public IReadOnlyCollection<CustomerGroupAttr>? attributes { get; init; }

    /// <summary>
    /// CustomerGroupI18n
    /// </summary>
    public IReadOnlyCollection<CustomerGroupI18n>? i18ns { get; init; }

}

