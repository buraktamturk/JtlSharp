namespace Jtl.Connector.Core.Model;

public record Product2Category : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to category
    /// </summary>
    public Identity? categoryId { get; init; }

}

