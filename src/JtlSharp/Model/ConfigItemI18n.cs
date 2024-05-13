namespace Jtl.Connector.Core.Model;

public record ConfigItemI18n : AbstractI18n
{
    /// <summary>
    /// string Description (html). Will be ignored, if inheritProductName==true
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Config item name. Will be ignored if inheritProductName==true
    /// </summary>
    public string? name { get; init; }

}

