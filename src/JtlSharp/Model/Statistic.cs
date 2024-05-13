namespace Jtl.Connector.Core.Model;

public record Statistic : AbstractModel
{
    /// <summary>
    /// int
    /// </summary>
    public int? available { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? controllerName { get; init; }

}

