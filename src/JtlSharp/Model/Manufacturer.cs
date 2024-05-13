namespace Jtl.Connector.Core.Model;

public record Manufacturer : AbstractIdentity
{
    /// <summary>
    /// string Manufacturer (brand) name
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// string Optional url path e.g. 'Products-manufactured-by-X
    /// </summary>
    public string? urlPath { get; init; }

    /// <summary>
    /// string Optional manufacturer website URL
    /// </summary>
    public string? websiteUrl { get; init; }

    /// <summary>
    /// ManufacturerI18n
    /// </summary>
    public IReadOnlyCollection<ManufacturerI18n>? i18ns { get; init; }

}

