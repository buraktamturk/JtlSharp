namespace Jtl.Connector.Core.Model;

public record CategoryI18n : AbstractI18n
{
    /// <summary>
    /// string Optional localized Long Description
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Optional localized  short description used for meta tag description
    /// </summary>
    public string? metaDescription { get; init; }

    /// <summary>
    /// string Optional localized meta tag keywords value
    /// </summary>
    public string? metaKeywords { get; init; }

    /// <summary>
    /// string Localized category name
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// string Optional localized title tag value
    /// </summary>
    public string? titleTag { get; init; }

    /// <summary>
    /// string Optional localized category URL
    /// </summary>
    public string? urlPath { get; init; }

}

