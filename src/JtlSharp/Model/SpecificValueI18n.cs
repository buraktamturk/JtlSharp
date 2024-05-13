namespace Jtl.Connector.Core.Model;

public record SpecificValueI18n : AbstractI18n
{
    /// <summary>
    /// string Optional localized description
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Optional localized meta description value
    /// </summary>
    public string? metaDescription { get; init; }

    /// <summary>
    /// string Optional localized meta keywords value
    /// </summary>
    public string? metaKeywords { get; init; }

    /// <summary>
    /// string Optional localized title tag value
    /// </summary>
    public string? titleTag { get; init; }

    /// <summary>
    /// string Optional localized URL path
    /// </summary>
    public string? urlPath { get; init; }

    /// <summary>
    /// string Localized value
    /// </summary>
    public string? value { get; init; }

}

