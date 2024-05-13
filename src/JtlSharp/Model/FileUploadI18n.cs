namespace Jtl.Connector.Core.Model;

public record FileUploadI18n : AbstractI18n
{
    /// <summary>
    /// string
    /// </summary>
    public string? description { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? fileUploadId { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? name { get; init; }

}

