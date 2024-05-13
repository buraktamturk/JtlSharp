namespace Jtl.Connector.Core.Model;

public record PartsList : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to a component / product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// double Component quantity
    /// </summary>
    public decimal? quantity { get; init; }

}

