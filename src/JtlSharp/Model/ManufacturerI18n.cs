namespace Jtl.Connector.Core.Model;

public record ManufacturerI18n : AbstractI18n
{
    /// <summary>
    /// string Optional manufacturer description (HTML
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Optional meta description tag value
    /// </summary>
    public string? metaDescription { get; init; }

    /// <summary>
    /// string Optional meta keywords tag value
    /// </summary>
    public string? metaKeywords { get; init; }

    /// <summary>
    /// string Optional title tag value
    /// </summary>
    public string? titleTag { get; init; }

}

