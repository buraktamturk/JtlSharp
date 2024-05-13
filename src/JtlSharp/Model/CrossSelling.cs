namespace Jtl.Connector.Core.Model;

public record CrossSelling : AbstractIdentity
{
    /// <summary>
    /// Identity Source product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// CrossSellingItem[] Referenced cross-sold products grouped by their crossSellingGroup
    /// </summary>
    public IReadOnlyCollection<CrossSellingItem>? items { get; init; }

}

