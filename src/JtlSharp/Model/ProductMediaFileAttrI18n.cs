namespace Jtl.Connector.Core.Model;

public record ProductMediaFileAttrI18n : AbstractI18n
{
    /// <summary>
    /// string
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? value { get; init; }

}

