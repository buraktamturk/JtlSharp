namespace Jtl.Connector.Core.Model;

public record ConfigGroup : AbstractIdentity
{
    /// <summary>
    /// string Optional internal comment to differantiate config groups by comment name
    /// </summary>
    public string? comment { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? imagePath { get; init; }

    /// <summary>
    /// integer Optional maximum number allowed selections. Default 0 for no maximum limitation
    /// </summary>
    public int? maximumSelection { get; init; }

    /// <summary>
    /// integer Optional minimum number required selections. Default 0 for no minimum requirement
    /// </summary>
    public int? minimumSelection { get; init; }

    /// <summary>
    /// integer Optional sort order number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// integer Config group item type. 0: Checkbox, 1:Radio, 2, Dropdown, 3: Multiselect
    /// </summary>
    public int? type { get; init; }

    /// <summary>
    /// ConfigGroupI18n
    /// </summary>
    public IReadOnlyCollection<ConfigGroupI18n>? i18ns { get; init; }

}

