namespace Jtl.Connector.Core.Model;

public record Currency : AbstractIdentity
{
    /// <summary>
    /// string Optional delimiter char for cent, default=",".
     ///              Ignore this flag if you have the correct user locale preference
    /// </summary>
    public string? delimiterCent { get; init; }

    /// <summary>
    /// string Optional delimiter char for thousand. Default=".".
     ///              Ignore this flag if you have the correct user locale preference
    /// </summary>
    public string? delimiterThousand { get; init; }

    /// <summary>
    /// double Optional conversion factor to default currency. Default is 1 (equals default currency
    /// </summary>
    public decimal? factor { get; init; }

    /// <summary>
    /// boolean Optional: Display currency before or after value.
     ///                  Ignore this flag if you have the correct user locale preference
    /// </summary>
    public bool? hasCurrencySignBeforeValue { get; init; }

    /// <summary>
    /// boolean Optional: Flag default currency. True, if this is the default currency.
     ///                  Exact one currency must be marked as default
    /// </summary>
    public bool? isDefault { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? iso { get; init; }

    /// <summary>
    /// string Currency name
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// string Optional HTML name e.g. "&euro
    /// </summary>
    public string? nameHtml { get; init; }

}

