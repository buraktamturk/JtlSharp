namespace Jtl.Connector.Core.Model;

public record ProductMediaFileAttr : AbstractModel
{
    /// <summary>
    /// ProductMediaFileAttrI18n
    /// </summary>
    public IReadOnlyCollection<ProductMediaFileAttrI18n>? i18ns { get; init; }

}

