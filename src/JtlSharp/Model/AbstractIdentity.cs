namespace Jtl.Connector.Core.Model;

public record AbstractIdentity : AbstractModel
{
    /// <summary>
    /// Identity Unique id
    /// </summary>
    public Identity? id { get; init; }

}

