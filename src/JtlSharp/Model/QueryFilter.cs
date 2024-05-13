namespace Jtl.Connector.Core.Model;

public record QueryFilter : AbstractModel
{
    /// <summary>
    /// integer
    /// </summary>
    public int? limit { get; init; }

    /// <summary>
    /// array<string, string
    /// </summary>
    public IReadOnlyDictionary<string, string>? filters { get; init; }

}

