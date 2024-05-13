namespace Jtl.Connector.Core.Model;

public record AbstractI18n : AbstractModel
{
    /// <summary>
    /// string
    /// </summary>
    public string? languageIso { get; init; }

}

