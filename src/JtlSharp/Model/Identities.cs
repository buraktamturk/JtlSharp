namespace Jtl.Connector.Core.Model;

public record Identities : AbstractModel
{
    /// <summary>
    /// array<string, array<int, Identity>|null
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlyCollection<Identity>>? identities { get; init; }

}

