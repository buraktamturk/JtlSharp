namespace Jtl.Connector.Core.Model;

public record Session : AbstractModel
{
    /// <summary>
    /// string|null
    /// </summary>
    public string? sessionId { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? lifetime { get; init; }

}

