namespace Jtl.Connector.Core.Model;

public record ProductSpecialPriceItem : AbstractModel
{
    /// <summary>
    /// Identity Reference to customerGroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// double net price value
    /// </summary>
    public decimal? priceNet { get; init; }

}

