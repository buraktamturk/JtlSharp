namespace Jtl.Connector.Core.Model;

public record ProductPartsList : AbstractIdentity
{
    /// <summary>
    /// double Component quantity
    /// </summary>
    public decimal? quantity { get; init; }

}

