namespace Jtl.Connector.Core.Model;

public record Ack : Identities
{
    /// <summary>
    /// Checksum
    /// </summary>
    public IReadOnlyCollection<Checksum>? checksums { get; init; }

}

