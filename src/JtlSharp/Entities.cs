using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public record Entities
{
    [JsonPropertyName("Category")]
    public Feature<Category> Category { get; init; } = new();
    
    [JsonPropertyName("CategoryI18n")]
    public BoolFeature CategoryI18n { get; init; } = new();
    
    [JsonPropertyName("CategoryAttr")]
    public BoolFeature CategoryAttribute { get; init; } = new();
    
    [JsonPropertyName("CategoryAttrI18n")]
    public BoolFeature CategoryAttrI18n { get; init; } = new();
    
    [JsonPropertyName("CategoryCustomerGroup")]
    public BoolFeature CategoryCustomerGroup { get; init; } = new();
    
    [JsonPropertyName("CategoryInvisibility")]
    public Feature<CategoryInvisibility> CategoryInvisibility { get; init; } = new();
    
    [JsonPropertyName("ConfigGroup")]
    public Feature<ConfigGroup> ConfigGroup { get; init; } = new();
    
    [JsonPropertyName("ConfigGroupI18n")]
    public BoolFeature ConfigGroupI18n { get; init; } = new();
    
    [JsonPropertyName("ConfigItem")]
    public Feature<ConfigItem> ConfigItem { get; init; } = new();
    
    [JsonPropertyName("ConfigItemI18n")]
    public BoolFeature ConfigItemI18n { get; init; } = new();
    
    [JsonPropertyName("ConfigItemPrice")]
    public Feature<ConfigItemPrice> ConfigItemPrice { get; init; } = new();
    
    [JsonPropertyName("CrossSelling")]
    public Feature<CrossSelling> CrossSelling { get; init; } = new();
    
    [JsonPropertyName("CrossSellingGroup")]
    public Feature<CrossSellingGroup> CrossSellingGroup { get; init; } = new();
    
    [JsonPropertyName("CrossSellingGroupI18n")]
    public BoolFeature CrossSellingGroupI18n { get; init; } = new();
    
    [JsonPropertyName("CrossSellingItem")]
    public BoolFeature CrossSellingItem { get; init; } = new();
    
    [JsonPropertyName("Currency")]
    public Feature<Currency> Currency { get; init; } = new();
    
    [JsonPropertyName("Customer")]
    public Feature<Customer> Customer { get; init; } = new();
    
    [JsonPropertyName("CustomerAttr")]
    public BoolFeature CustomerAttr { get; init; } = new();
    
    [JsonPropertyName("CustomerGroup")]
    public Feature<CustomerGroup> CustomerGroup { get; init; } = new();
    
    [JsonPropertyName("CustomerGroupAttr")]
    public BoolFeature CustomerGroupAttr { get; init; } = new();
    
    [JsonPropertyName("CustomerGroupI18n")]
    public BoolFeature CustomerGroupI18n { get; init; } = new();
    
    [JsonPropertyName("CustomerGroupPackagingQuantity")]
    public Feature<CustomerGroupPackagingQuantity> CustomerGroupPackagingQuantity { get; init; } = new();
    
    [JsonPropertyName("CustomerOrder")]
    public Feature<CustomerOrder> CustomerOrder { get; init; } = new();
    
    [JsonPropertyName("CustomerOrderAttr")]
    public BoolFeature CustomerOrderAttr { get; init; } = new();
    
    [JsonPropertyName("CustomerOrderBillingAddress")]
    public BoolFeature CustomerOrderBillingAddress { get; init; } = new();
    
    [JsonPropertyName("CustomerOrderItem")]
    public BoolFeature CustomerOrderItem { get; init; } = new();
    
    [JsonPropertyName("CustomerOrderItemVariation")]
    public BoolFeature CustomerOrderItemVariation { get; init; } = new();
    
    [JsonPropertyName("CustomerOrderPaymentInfo")]
    public BoolFeature CustomerOrderPaymentInfo { get; init; } = new();
    
    [JsonPropertyName("CustomerOrderShippingAddress")]
    public BoolFeature CustomerOrderShippingAddress { get; init; } = new();
    
    [JsonPropertyName("DeliveryNote")]
    public Feature<DeliveryNote> DeliveryNote { get; init; } = new();
    
    [JsonPropertyName("DeliveryNoteItem")]
    public BoolFeature DeliveryNoteItem { get; init; } = new();
    
    [JsonPropertyName("DeliveryNoteItemInfo")]
    public BoolFeature DeliveryNoteItemInfo { get; init; } = new();
    
    [JsonPropertyName("DeliveryNoteTrackingList")]
    public BoolFeature DeliveryNoteTrackingList { get; init; } = new();
    
    [JsonPropertyName("FileUpload")]
    public Feature<FileUpload> FileUpload { get; init; } = new();

    [JsonPropertyName("FileUploadI18n")]
    public BoolFeature FileUploadI18n { get; init; } = new();
    
    [JsonPropertyName("Image")]
    public Feature<AbstractImage> Image { get; init; } = new();
    
    [JsonPropertyName("Language")]
    public Feature<Language> Language { get; init; } = new();
    
    [JsonPropertyName("Manufacturer")]
    public Feature<Manufacturer> Manufacturer { get; init; } = new();
    
    [JsonPropertyName("ManufacturerI18n")]
    public BoolFeature ManufacturerI18n { get; init; } = new();
    
    [JsonPropertyName("MeasurementUnit")]
    public Feature<MeasurementUnit> MeasurementUnit { get; init; } = new();
    
    [JsonPropertyName("MeasurementUnitI18n")]
    public BoolFeature MeasurementUnitI18n { get; init; } = new();
    
    [JsonPropertyName("PartsList")]
    public Feature<PartsList> PartsList { get; init; } = new();
    
    [JsonPropertyName("Payment")]
    public Feature<Payment> Payment { get; init; } = new();
    
    [JsonPropertyName("Product")]
    public Feature<Product> Product { get; init; } = new();

    [JsonPropertyName("Product2Category")]
    public BoolFeature Product2Category { get; init; } = new();
    
    [JsonPropertyName("ProductAttr")]
    public BoolFeature ProductAttr { get; init; } = new();
    
    [JsonPropertyName("ProductAttrI18n")]
    public BoolFeature ProductAttrI18n { get; init; } = new();
    
    [JsonPropertyName("ProductConfigGroup")]
    public BoolFeature ProductConfigGroup { get; init; } = new();
    
    [JsonPropertyName("ProductFileDownload")]
    public BoolFeature ProductFileDownload { get; init; } = new();
    
    [JsonPropertyName("ProductFileDownloadI18n")]
    public BoolFeature ProductFileDownloadI18n { get; init; } = new();

    
    [JsonPropertyName("ProductI18n")]
    public BoolFeature ProductI18n { get; init; } = new();

    
    [JsonPropertyName("ProductInvisibility")]
    public BoolFeature ProductInvisibility { get; init; } = new();
    
    [JsonPropertyName("ProductMediaFile")]
    public Feature<ProductMediaFile> MediaFile { get; init; } = new();
    
    [JsonPropertyName("ProductMediaFileAttr")]
    public BoolFeature ProductMediaFileAttr { get; init; } = new();
    
    [JsonPropertyName("ProductMediaFileAttrI18n")]
    public BoolFeature ProductMediaFileAttrI18n { get; init; } = new();
    
    [JsonPropertyName("ProductMediaFileI18n")]
    public BoolFeature ProductMediaFileI18n { get; init; } = new();
    
    [JsonPropertyName("ProductPartsList")]
    public BoolFeature ProductPartsList { get; init; } = new();

    [JsonPropertyName("ProductPrice")]
    public Feature<ProductPrice> ProductPrice { get; init; } = new();

    [JsonPropertyName("ProductPriceItem")]
    public BoolFeature ProductPriceItem { get; init; } = new();

    [JsonPropertyName("ProductSpecialPrice")]
    public BoolFeature ProductSpecialPrice { get; init; } = new();
    
    [JsonPropertyName("ProductSpecialPriceItem")]
    public BoolFeature ProductSpecialPriceItem { get; init; } = new();

    [JsonPropertyName("ProductSpecific")]
    public BoolFeature ProductSpecific { get; init; } = new();

    [JsonPropertyName("ProductStockLevel")]
    public Feature<ProductStockLevel> ProductStockLevel { get; init; } = new();

    [JsonPropertyName("ProductType")]
    public Feature<ProductType> ProductType { get; init; } = new();
    
    [JsonPropertyName("ProductVarCombination")]
    public BoolFeature ProductVarCombination { get; init; } = new();
    
    [JsonPropertyName("ProductVariation")]
    public BoolFeature ProductVariation { get; init; } = new();
    
    [JsonPropertyName("ProductVariationI18n")]
    public BoolFeature ProductVariationI18n { get; init; } = new();
    
    [JsonPropertyName("ProductVariationInvisibility")]
    public BoolFeature ProductVariationInvisibility { get; init; } = new();
    
    [JsonPropertyName("ProductVariationValue")]
    public BoolFeature ProductVariationValue { get; init; } = new();
    
    [JsonPropertyName("ProductVariationValueDependency")]
    public BoolFeature ProductVariationValueDependency { get; init; } = new();
    
    [JsonPropertyName("ProductVariationValueExtraCharge")]
    public BoolFeature ProductVariationValueExtraCharge { get; init; } = new();
    
    [JsonPropertyName("ProductVariationValueI18n")]
    public BoolFeature ProductVariationValueI18n { get; init; } = new();
    
    [JsonPropertyName("ProductVariationValueInvisibility")]
    public BoolFeature ProductVariationValueInvisibility { get; init; } = new();
    
    [JsonPropertyName("ProductWarehouseInfo")]
    public BoolFeature ProductWarehouseInfo { get; init; } = new();
    
    [JsonPropertyName("Shipment")]
    public BoolFeature Shipment { get; init; } = new();
    
    [JsonPropertyName("ShippingClass")]
    public Feature<ShippingClass> ShippingClass { get; init; } = new();
    
    [JsonPropertyName("ShippingMethod")]
    public Feature<ShippingMethod> ShippingMethod { get; init; } = new();
    
    [JsonPropertyName("Specific")]
    public Feature<Specific> Specific { get; init; } = new();
    
    [JsonPropertyName("SpecificI18n")]
    public BoolFeature SpecificI18n { get; init; } = new();
    
    [JsonPropertyName("SpecificValue")]
    public AckBoolFeature SpecificValue { get; init; } = new();
    
    [JsonPropertyName("SpecificValueI18n")]
    public BoolFeature SpecificValueI18n { get; init; } = new();
    
    [JsonPropertyName("StatusChange")]
    public Feature<StatusChange> StatusChange { get; init; } = new();
    
    [JsonPropertyName("TaxClass")]
    public Feature<TaxClass> TaxClass { get; init; } = new();
    
    [JsonPropertyName("TaxRate")]
    public Feature<TaxRate> TaxRate { get; init; } = new();
    
    [JsonPropertyName("TaxZone")]
    public Feature<TaxZone> TaxZone { get; init; } = new();
    
    [JsonPropertyName("TaxZoneCountry")]
    public BoolFeature TaxZoneCountry { get; init; } = new();
    
    [JsonPropertyName("Unit")]
    public Feature<Unit> Unit { get; init; } = new();
    
    [JsonPropertyName("UnitI18n")]
    public BoolFeature UnitI18n { get; init; } = new();
    
    [JsonPropertyName("Warehouse")]
    public Feature<Warehouse> Warehouse { get; init; } = new();
}

public static class EntitiesExtensions
{
    public static IAckFeature GetAckFeature(this Entities entities, string type)
    {
        return type.ToLowerInvariant() switch
        {
            "manufacturer" => (IAckFeature)entities.Manufacturer,
            //"manufacturerI18n" => (IAckFeature)entities.ManufacturerI18n,
            "category" => (IAckFeature)entities.Category,
            //"categoryI18n" => (IAckFeature)entities.CategoryI18n,
            //"categoryAttr" => (IAckFeature)entities.CategoryAttribute,
            // "categorycustomergroup" => (IAckFeature)entities.CategoryCustomerGroup,
            "categoryinvisibility" => (IAckFeature)entities.CategoryInvisibility,
            "configgroup" => (IAckFeature)entities.ConfigGroup,
            //"configGroupI18n" => (IAckFeature)entities.ConfigGroupI18n,
            "configitem" => (IAckFeature)entities.ConfigItem,
            //"configItemI18n" => (IAckFeature)entities.ConfigItemI18n,
            "configitemprice" => (IAckFeature)entities.ConfigItemPrice,
            "crossselling" => (IAckFeature)entities.CrossSelling,
            "crosssellinggroup" => (IAckFeature)entities.CrossSellingGroup,
            //"crossSellingGroupI18n" => (IAckFeature)entities.CrossSellingGroupI18n,
            // "crosssellingitem" => (IAckFeature)entities.CrossSellingItem,
            "currency" => (IAckFeature)entities.Currency,
            "customer" => (IAckFeature)entities.Customer,
            "customergroup" => (IAckFeature)entities.CustomerGroup,
            //"customerGroupAttr" => (IAckFeature)entities.CustomerGroupAttr,
            //"customerGroupI18n" => (IAckFeature)entities.CustomerGroupI18n,
            "customergrouppackagingquantity" => (IAckFeature)entities.CustomerGroupPackagingQuantity,
            "customerorder" => (IAckFeature)entities.CustomerOrder,
            //"customerOrderAttr" => (IAckFeature)entities.CustomerOrderAttr,
            //"customerOrderBillingAddress" => (IAckFeature)entities.CustomerOrderBillingAddress,
            //"customerOrderItem" => (IAckFeature)entities.CustomerOrderItem,
            //"customerOrderItemVariation" => (IAckFeature)entities.CustomerOrderItemVariation,
            //"customerOrderPaymentInfo" => (IAckFeature)entities.CustomerOrderPaymentInfo,
            //"customerOrderShippingAddress" => (IAckFeature)entities.CustomerOrderShippingAddress,
            "deliverynote" => (IAckFeature)entities.DeliveryNote,
            //"deliveryNoteItem" => (IAckFeature)entities.DeliveryNoteItem,
            //"deliveryNoteItemInfo" => (IAckFeature)entities.DeliveryNoteItemInfo,
            //"fileDownload" => (IAckFeature)entities.FileDownload,
            //"fileDownloadI18n" => (IAckFeature)entities.FileDownloadI18n,
            "fileupload" => (IAckFeature)entities.FileUpload,
            //"fileUploadI18n" => (IAckFeature)entities.FileUploadI18n,
            "image" => (IAckFeature)entities.Image,
            "language" => (IAckFeature)entities.Language,
            "measurementunit" => (IAckFeature)entities.MeasurementUnit,
            //"measurementUnitI18n" => (IAckFeature)entities.MeasurementUnitI18n,
            "mediafile" => (IAckFeature)entities.MediaFile,
            //"mediaFileAttr" => (IAckFeature)entities.MediaFileAttr,
            //"mediaFileAttrI18n" => (IAckFeature)entities.MediaFileAttrI18n,
            "partslist" => (IAckFeature)entities.PartsList,
            "payment" => (IAckFeature)entities.Payment,
            "product" => (IAckFeature)entities.Product,
            //"product2Category" => (IAckFeature)entities.Product2Category,
            //"productAttr" => (IAckFeature)entities.ProductAttr,
            //"productAttrI18n" => (IAckFeature)entities.ProductAttrI18n,
            //"productConfigGroup" => (IAckFeature)entities.ProductConfigGroup,
            //"productFileDownload" => (IAckFeature)entities.ProductFileDownload,
            //"productI18n" => (IAckFeature)entities.ProductI18n,
            //"productInvisibility" => (IAckFeature)entities.ProductInvisibility,
            //"productPartsList" => (IAckFeature)entities.ProductPartsList,
            //"productPrice" => (IAckFeature)entities.ProductPrice,
            //"productPriceItem" => (IAckFeature)entities.ProductPriceItem,
            //"productSpecialPrice" => (IAckFeature)entities.ProductSpecialPrice,
            //"productSpecialPriceItem" => (IAckFeature)entities.ProductSpecialPriceItem,
            //"productSpecific" => (IAckFeature)entities.ProductSpecific,
            "productstocklevel" => entities.ProductStockLevel,
            "producttype" => (IAckFeature)entities.ProductType,
            //"productVarCombination" => (IAckFeature)entities.ProductVarCombination,
            //"productVariation" => (IAckFeature)entities.ProductVariation,
            //"productVariationI18n" => (IAckFeature)entities.ProductVariationI18n,
            //"productVariationInvisibility" => (IAckFeature)entities.ProductVariationInvisibility,
            //"productVariationValue" => (IAckFeature)entities.ProductVariationValue,
            //"productVariationValueDependency" => (IAckFeature)entities.ProductVariationValueDependency,
            //"productVariationValueExtraCharge" => (IAckFeature)entities.ProductVariationValueExtraCharge,
            //"productVariationValueI18n" => (IAckFeature)entities.ProductVariationValueI18n,
            //"productVariationValueInvisibility" => (IAckFeature)entities.ProductVariationValueInvisibility,
            //"productWarehouseInfo" => (IAckFeature)entities.ProductWarehouseInfo,
            //"shipment" => (IAckFeature)entities.Shipment,
            "shippingclass" => (IAckFeature)entities.ShippingClass,
            "shippingmethod" => (IAckFeature)entities.ShippingMethod,
            "specific" => (IAckFeature)entities.Specific,
            //"specificI18n" => (IAckFeature)entities.SpecificI18n,
            "specificvalue" => (IAckFeature)entities.SpecificValue,
            //"specificValueI18n" => (IAckFeature)entities.SpecificValueI18n,
            //"statistic" => (IAckFeature)entities.Statistic,
            "statuschange" => (IAckFeature)entities.StatusChange,
            "taxclass" => (IAckFeature)entities.TaxClass,
            "taxrate" => (IAckFeature)entities.TaxRate,
            "taxzone" => (IAckFeature)entities.TaxZone,
            //"taxZoneCountry" => (IAckFeature)entities.TaxZoneCountry,
            "unit" => (IAckFeature)entities.Unit,
            //"unitI18n" => (IAckFeature)entities.UnitI18n,
            "warehouse" => (IAckFeature)entities.Warehouse,
            "productprice" => entities.ProductPrice,
            _ => throw new NotImplementedException($"Unknown entity type for ACK: {type}")
        };
    }

    public static async Task<bool> ProcessAck(this Entities entities, Ack ack, bool isClear = false)
    {
        foreach (var (key, value) in ack.identities)
        {
            await entities.GetAckFeature(key).Ack?.Invoke(value, isClear);
        }

        return true;
    }
}
