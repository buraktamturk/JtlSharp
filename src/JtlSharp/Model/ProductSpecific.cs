namespace Jtl.Connector.Core.Model;

public record ProductSpecific : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to specificValue
    /// </summary>
    public Identity? specificValueId { get; init; }

}

