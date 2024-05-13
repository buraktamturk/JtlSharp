namespace Jtl.Connector.Core.Model;

public record ProductVariationValueI18n : AbstractI18n
{
    /// <summary>
    /// string Locale specific variationValue name
    /// </summary>
    public string? name { get; init; }

}

