namespace Jtl.Connector.Core.Model;

public record ProductStockLevel : AbstractModel
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? stockLevel { get; init; }

}

