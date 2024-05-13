namespace Jtl.Connector.Core.Model;

public record ProductMediaFileI18n : AbstractI18n
{
    /// <summary>
    /// string Locale specific description
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string Locale specific name
    /// </summary>
    public string? name { get; init; }

}

