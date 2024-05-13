namespace Jtl.Connector.Core.Model;

public record SpecificI18n : AbstractI18n
{
    /// <summary>
    /// string Localized name
    /// </summary>
    public string? name { get; init; }

}

