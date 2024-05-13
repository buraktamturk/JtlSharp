namespace Jtl.Connector.Core.Model;

public record ConnectorServerInfo : AbstractModel
{
    /// <summary>
    /// integer
    /// </summary>
    public int? memoryLimit { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? executionTime { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? postMaxSize { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? uploadMaxFilesize { get; init; }

}

