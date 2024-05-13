namespace Jtl.Connector.Core.Model;

public record CrossSellingGroupI18n : AbstractI18n
{
    /// <summary>
    /// string Optional localized description
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Localized name
    /// </summary>
    public string? name { get; init; }

}

