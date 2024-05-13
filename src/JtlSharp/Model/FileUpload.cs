namespace Jtl.Connector.Core.Model;

public record FileUpload : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? fileType { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? isRequired { get; init; }

    /// <summary>
    /// FileUploadI18n
    /// </summary>
    public IReadOnlyCollection<FileUploadI18n>? i18ns { get; init; }

}

