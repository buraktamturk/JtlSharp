namespace Jtl.Connector.Core.Model;

public record ProductPriceItem : AbstractModel
{
    /// <summary>
    /// double Price value (net
    /// </summary>
    public decimal? netPrice { get; init; }

    /// <summary>
    /// integer Optional quantity to apply netPrice for. Default 1 for default price.
     ///              A quantity value of 3 means that the given product price
     ///              will be applied when a customer buys 3 or more items
    /// </summary>
    public int? quantity { get; init; }

}

