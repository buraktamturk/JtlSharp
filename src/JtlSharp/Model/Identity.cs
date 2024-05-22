namespace Jtl.Connector.Core.Model;

public record Identity : AbstractModel
{
    /// <summary>
    /// string
    /// </summary>
    public string? endpoint { get; init; }

    /// <summary>
    /// int
    /// </summary>
    public int? host { get; init; }

    public static readonly Identity Empty = new Identity() { endpoint = string.Empty, host = 0 };
}

