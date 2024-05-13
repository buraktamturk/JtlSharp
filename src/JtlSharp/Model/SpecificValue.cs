namespace Jtl.Connector.Core.Model;

public record SpecificValue : AbstractIdentity
{
    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// SpecificValueI18n
    /// </summary>
    public IReadOnlyCollection<SpecificValueI18n>? i18ns { get; init; }

}

