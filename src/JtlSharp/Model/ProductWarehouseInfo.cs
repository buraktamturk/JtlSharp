namespace Jtl.Connector.Core.Model;

public record ProductWarehouseInfo : AbstractModel
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? warehouseId { get; init; }

    /// <summary>
    /// double Optional product inflow quantity for specified warehouse
    /// </summary>
    public decimal? inflowQuantity { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? stockLevel { get; init; }

}

