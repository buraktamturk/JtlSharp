namespace Jtl.Connector.Core.Model;

public record CategoryCustomerGroup : AbstractModel
{
    /// <summary>
    /// Identity Reference to customerGroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// double Optional discount on products in specified categoryId for  customerGroupId
    /// </summary>
    public decimal? discount { get; init; }

}

