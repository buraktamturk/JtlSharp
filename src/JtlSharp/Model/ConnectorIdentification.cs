namespace Jtl.Connector.Core.Model;

public record ConnectorIdentification : AbstractModel
{
    /// <summary>
    /// string
    /// </summary>
    public string? endpointVersion { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? platformName { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? platformVersion { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? protocolVersion { get; init; }

    /// <summary>
    /// ConnectorServerInfo|null
    /// </summary>
    public ConnectorServerInfo? serverInfo { get; init; }

}

