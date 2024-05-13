namespace Jtl.Connector.Core.Model;

public record ProductMediaFile : AbstractIdentity
{
    /// <summary>
    /// string Optional media file category name
    /// </summary>
    public string? mediaFileCategory { get; init; }

    /// <summary>
    /// string File path
    /// </summary>
    public string? path { get; init; }

    /// <summary>
    /// integer Optional sort number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// string Media file type e.g. 'pdf
    /// </summary>
    public string? type { get; init; }

    /// <summary>
    /// string Complete URL
    /// </summary>
    public string? url { get; init; }

    /// <summary>
    /// ProductMediaFileAttr
    /// </summary>
    public IReadOnlyCollection<ProductMediaFileAttr>? attributes { get; init; }

    /// <summary>
    /// ProductMediaFileI18n
    /// </summary>
    public IReadOnlyCollection<ProductMediaFileI18n>? i18ns { get; init; }

}

