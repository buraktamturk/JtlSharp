namespace Jtl.Connector.Core.Model;

public record ConfigGroupI18n : AbstractI18n
{
    /// <summary>
    /// string Optional description (HTML
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Config group name
    /// </summary>
    public string? name { get; init; }

}

