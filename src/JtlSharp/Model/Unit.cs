namespace Jtl.Connector.Core.Model;

public record Unit : AbstractIdentity
{
    /// <summary>
    /// UnitI18n
    /// </summary>
    public IReadOnlyCollection<UnitI18n>? i18ns { get; init; }

}

