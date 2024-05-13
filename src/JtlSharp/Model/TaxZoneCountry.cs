namespace Jtl.Connector.Core.Model;

public record TaxZoneCountry : AbstractModel
{
    /// <summary>
    /// string Country ISO 3166-2 (2 letter Uppercase
    /// </summary>
    public string? countryIso { get; init; }

}

