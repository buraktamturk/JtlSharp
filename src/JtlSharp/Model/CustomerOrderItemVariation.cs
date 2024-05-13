namespace Jtl.Connector.Core.Model;

public record CustomerOrderItemVariation : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to productVariation
    /// </summary>
    public Identity? productVariationId { get; init; }

    /// <summary>
    /// Identity Reference to productVariationValue
    /// </summary>
    public Identity? productVariationValueId { get; init; }

    /// <summary>
    /// string Optional custom text value for variation
    /// </summary>
    public string? freeField { get; init; }

    /// <summary>
    /// string Variation name e.g. 'color
    /// </summary>
    public string? productVariationName { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? surcharge { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? valueName { get; init; }

}

