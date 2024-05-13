namespace Jtl.Connector.Core.Model;

public record KeyValueAttribute : AbstractModel
{
    /// <summary>
    /// string Attribute key
    /// </summary>
    public string? key { get; init; }

    /// <summary>
    /// string Attribute value
    /// </summary>
    public string? value { get; init; }

}

