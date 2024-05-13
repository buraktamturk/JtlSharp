namespace Jtl.Connector.Core.Model;

public record TaxZone : AbstractIdentity
{
    /// <summary>
    /// string Optional tax zone name e.g. "EU Zone
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// TaxZoneCountry
    /// </summary>
    public IReadOnlyCollection<TaxZoneCountry>? countries { get; init; }

}

