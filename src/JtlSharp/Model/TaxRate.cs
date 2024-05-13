namespace Jtl.Connector.Core.Model;

public record TaxRate : AbstractIdentity
{
    /// <summary>
    /// string
    /// </summary>
    public string? countryIso { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? rate { get; init; }

}

