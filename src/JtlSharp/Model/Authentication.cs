namespace Jtl.Connector.Core.Model;

public record Authentication : AbstractModel
{
    /// <summary>
    /// string
    /// </summary>
    public string? token { get; init; }

}

