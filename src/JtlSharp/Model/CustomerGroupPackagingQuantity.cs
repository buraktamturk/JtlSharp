namespace Jtl.Connector.Core.Model;

public record CustomerGroupPackagingQuantity : AbstractModel
{
    /// <summary>
    /// Identity Reference to customergroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// double Contains the minimum quantity for a customergroup
    /// </summary>
    public decimal? minimumOrderQuantity { get; init; }

    /// <summary>
    /// double Product can only be purchased in multiples of takeOffQuantity e.g. 5,10,15
    /// </summary>
    public decimal? packagingQuantity { get; init; }

}

