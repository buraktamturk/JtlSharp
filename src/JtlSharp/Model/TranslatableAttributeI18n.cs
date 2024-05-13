namespace Jtl.Connector.Core.Model;

public record TranslatableAttributeI18n : AbstractI18n
{
    /// <summary>
    /// string
    /// </summary>
    public string? value { get; init; }

}

