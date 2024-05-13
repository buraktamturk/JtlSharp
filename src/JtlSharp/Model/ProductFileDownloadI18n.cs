namespace Jtl.Connector.Core.Model;

public record ProductFileDownloadI18n : AbstractI18n
{
    /// <summary>
    /// string
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? name { get; init; }

}

