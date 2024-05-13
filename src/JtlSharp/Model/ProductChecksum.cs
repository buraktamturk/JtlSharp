namespace Jtl.Connector.Core.Model;

public record ProductChecksum : Checksum
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? foreignKey { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? endpoint { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? hasChanged { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? host { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? type { get; init; }

}

