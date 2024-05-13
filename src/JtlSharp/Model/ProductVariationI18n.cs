namespace Jtl.Connector.Core.Model;

public record ProductVariationI18n : AbstractI18n
{
    /// <summary>
    /// string Locale specific variation name
    /// </summary>
    public string? name { get; init; }

}

