namespace Jtl.Connector.Core.Model;

public record CrossSellingGroup : AbstractIdentity
{
    /// <summary>
    /// CrossSellingGroupI18n
    /// </summary>
    public IReadOnlyCollection<CrossSellingGroupI18n>? i18ns { get; init; }

}

