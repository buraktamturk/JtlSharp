namespace Jtl.Connector.Core.Model;

public record ProductVariation : AbstractIdentity
{
    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? type { get; init; }

    /// <summary>
    /// ProductVariationI18n
    /// </summary>
    public IReadOnlyCollection<ProductVariationI18n>? i18ns { get; init; }

    /// <summary>
    /// ProductVariationInvisibility
    /// </summary>
    public IReadOnlyCollection<ProductVariationInvisibility>? invisibilities { get; init; }

    /// <summary>
    /// ProductVariationValue
    /// </summary>
    public IReadOnlyCollection<ProductVariationValue>? values { get; init; }

}

