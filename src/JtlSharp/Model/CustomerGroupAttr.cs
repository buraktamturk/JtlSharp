namespace Jtl.Connector.Core.Model;

public record CustomerGroupAttr : KeyValueAttribute
{
    /// <summary>
    /// Identity Unique customerGroupAttr id
    /// </summary>
    public Identity? id { get; init; }

}

