namespace Jtl.Connector.Core.Model;

public record ProductVariationValueExtraCharge : AbstractModel
{
    /// <summary>
    /// Identity Reference to customerGroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// double Extra charge (net
    /// </summary>
    public decimal? extraChargeNet { get; init; }

}

