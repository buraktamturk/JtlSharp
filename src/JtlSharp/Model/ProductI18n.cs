namespace Jtl.Connector.Core.Model;

public record ProductI18n : AbstractI18n
{
    /// <summary>
    /// string
    /// </summary>
    public string? deliveryStatus { get; init; }

    /// <summary>
    /// string Optional product description
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? measurementUnitName { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? metaDescription { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? metaKeywords { get; init; }

    /// <summary>
    /// string Product name / title
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// string Optional product shortdescription
    /// </summary>
    public string? shortDescription { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? titleTag { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? unitName { get; init; }

    /// <summary>
    /// string Optional path of product URL
    /// </summary>
    public string? urlPath { get; init; }

}

