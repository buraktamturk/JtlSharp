namespace Jtl.Connector.Core.Model;

public record ConfigItem : AbstractIdentity
{
    /// <summary>
    /// Identity Reference to configGroup
    /// </summary>
    public Identity? configGroupId { get; init; }

    /// <summary>
    /// Identity Optional reference to product
    /// </summary>
    public Identity? productId { get; init; }

    /// <summary>
    /// integer     Optional:Ignore multiplier.
     ///                  If true, quantity of config item will not be increased if product quantity is increased
    /// </summary>
    public int? ignoreMultiplier { get; init; }

    /// <summary>
    /// boolean Optional: Inherit product name and description  if productId is set.
     ///                  If true, configItem name will be received from referenced
     ///                  product and configItemI18n name will be ignored
    /// </summary>
    public bool? inheritProductName { get; init; }

    /// <summary>
    /// boolean Optional: Inherit product price of referenced productId.
     ///              If true, configItem price will be the same as referenced product price
    /// </summary>
    public bool? inheritProductPrice { get; init; }

    /// <summary>
    /// double Optional initial / predefined quantity. Default is one (1) quantity piece
    /// </summary>
    public decimal? initialQuantity { get; init; }

    /// <summary>
    /// boolean Optional: Preselect configItem. If true, configItem will be preselected or prechecked
    /// </summary>
    public bool? isPreSelected { get; init; }

    /// <summary>
    /// boolean Optional: Highlight or recommend config item. If true, configItem will be recommended/highlighted
    /// </summary>
    public bool? isRecommended { get; init; }

    /// <summary>
    /// double Maximum allowed quantity. Default 0 for no maximum limit
    /// </summary>
    public decimal? maxQuantity { get; init; }

    /// <summary>
    /// double Optional minimum quantity required to add configItem. Default 0 for no minimum quantity
    /// </summary>
    public decimal? minQuantity { get; init; }

    /// <summary>
    /// boolean Optional: Show discount compared to productId price.
     ///              If true, the discount compared to referenct product price will be shown
    /// </summary>
    public bool? showDiscount { get; init; }

    /// <summary>
    /// boolean Optional: Show surcharge compared to productId price
    /// </summary>
    public bool? showSurcharge { get; init; }

    /// <summary>
    /// integer Optional sort order number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// integer Config item type. 0: Product, 1: Special
    /// </summary>
    public int? type { get; init; }

    /// <summary>
    /// ConfigItemI18n
    /// </summary>
    public IReadOnlyCollection<ConfigItemI18n>? i18ns { get; init; }

    /// <summary>
    /// ConfigItemPrice
    /// </summary>
    public IReadOnlyCollection<ConfigItemPrice>? prices { get; init; }

}

