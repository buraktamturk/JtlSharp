namespace Jtl.Connector.Core.Model;

public record TranslatableAttribute : AbstractIdentity
{
    /// <summary>
    /// boolean
    /// </summary>
    public bool? isCustomProperty { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? type { get; init; }

    /// <summary>
    /// TranslatableAttributeI18n
    /// </summary>
    public IReadOnlyCollection<TranslatableAttributeI18n>? i18ns { get; init; }

}

