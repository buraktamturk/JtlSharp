namespace Jtl.Connector.Core.Model;

public record ProductInvisibility : AbstractModel
{
    /// <summary>
    /// Identity Reference to customerGroup
    /// </summary>
    public Identity? customerGroupId { get; init; }

}

