namespace Jtl.Connector.Core.Model;

public record TaxClass : AbstractIdentity
{
    /// <summary>
    /// boolean Optional: Flag default tax class. Default is false. Exact 1 taxClass has to be marked as default
    /// </summary>
    public bool? isDefault { get; init; }

    /// <summary>
    /// string Optional tax class name
    /// </summary>
    public string? name { get; init; }

}

