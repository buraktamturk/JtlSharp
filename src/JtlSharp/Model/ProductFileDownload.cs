namespace Jtl.Connector.Core.Model;

public record ProductFileDownload : AbstractModel
{
    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? maxDays { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? maxDownloads { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? path { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? previewPath { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// ProductFileDownloadI18n
    /// </summary>
    public IReadOnlyCollection<ProductFileDownloadI18n>? i18ns { get; init; }

}

