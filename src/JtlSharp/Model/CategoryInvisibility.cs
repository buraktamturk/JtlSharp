namespace Jtl.Connector.Core.Model;

public record CategoryInvisibility : AbstractModel
{
    /// <summary>
    /// Identity Reference to customerGroup that is not allowed to view categoryId
    /// </summary>
    public Identity? customerGroupId { get; init; }

}

