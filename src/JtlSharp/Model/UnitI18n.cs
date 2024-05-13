namespace Jtl.Connector.Core.Model;

public record UnitI18n : AbstractI18n
{
    /// <summary>
    /// string Localized unit name
    /// </summary>
    public string? name { get; init; }

}

