namespace Jtl.Connector.Core.Model;

public record ConfigItemPrice : AbstractModel
{
    /// <summary>
    /// Identity Reference to customerGroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// double  Net price or percental value to add/deduct to/from product price (depending on type).
     ///              Positive value means surcharge, negative value means discount.
     ///              Also see configItem.vat for value added tax
    /// </summary>
    public decimal? price { get; init; }

    /// <summary>
    /// integer Optional type. Default is fixed price (Type 0). Type 1 defines percental price type
    /// </summary>
    public int? type { get; init; }

}

