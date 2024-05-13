namespace Jtl.Connector.Core.Model;

public record ProductConfigGroup : AbstractModel
{
    /// <summary>
    /// Identity Reference to configGroup
    /// </summary>
    public Identity? configGroupId { get; init; }

    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

}

