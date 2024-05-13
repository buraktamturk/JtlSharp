namespace Jtl.Connector.Core.Model;

public record CrossSellingItem : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to crossSellingGroup
    /// </summary>
    public Identity? crossSellingGroupId { get; init; }

    /// <summary>
    /// CrossSellingGroup|null
    /// </summary>
    public CrossSellingGroup? crossSellingGroup { get; init; }

    /// <summary>
    /// Identity[] Referenced target product ID
    /// </summary>
    public IReadOnlyCollection<Identity>? productIds { get; init; }

}

