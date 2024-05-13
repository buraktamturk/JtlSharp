namespace Jtl.Connector.Core.Model;

public record ProductVariationValue : AbstractIdentity
{
    /// <summary>
    /// string
    /// </summary>
    public string? ean { get; init; }

    /// <summary>
    /// double Optional variation extra weight
    /// </summary>
    public decimal? extraWeight { get; init; }

    /// <summary>
    /// string Optional Stock Keeping Unit
    /// </summary>
    public string? sku { get; init; }

    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// double Optional stock level
    /// </summary>
    public decimal? stockLevel { get; init; }

    /// <summary>
    /// ProductVariationValueExtraCharge
    /// </summary>
    public IReadOnlyCollection<ProductVariationValueExtraCharge>? extraCharges { get; init; }

    /// <summary>
    /// ProductVariationValueI18n
    /// </summary>
    public IReadOnlyCollection<ProductVariationValueI18n>? i18ns { get; init; }

    /// <summary>
    /// ProductVariationValueInvisibility
    /// </summary>
    public IReadOnlyCollection<ProductVariationValueInvisibility>? invisibilities { get; init; }

}

