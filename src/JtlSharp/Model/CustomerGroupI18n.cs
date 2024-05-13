namespace Jtl.Connector.Core.Model;

public record CustomerGroupI18n : AbstractI18n
{
    /// <summary>
    /// string Localized customer group name
    /// </summary>
    public string? name { get; init; }

}

