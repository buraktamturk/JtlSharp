namespace Jtl.Connector.Core.Model;

public record Specific : AbstractIdentity
{
    /// <summary>
    /// boolean Optional: Global specific means the specific can be used like a category
     ///              (e.g. show all red products in shop
    /// </summary>
    public bool? isGlobal { get; init; }

    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// string Specific type (radio, dropdown, image
    /// </summary>
    public string? type { get; init; }

    /// <summary>
    /// SpecificI18n
    /// </summary>
    public IReadOnlyCollection<SpecificI18n>? i18ns { get; init; }

    /// <summary>
    /// SpecificValue
    /// </summary>
    public IReadOnlyCollection<SpecificValue>? values { get; init; }

}

