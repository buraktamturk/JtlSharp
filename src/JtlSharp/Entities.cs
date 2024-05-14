using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public record Entities
{
    [JsonPropertyName("Manufacturer")]
    public Feature<Manufacturer> Manufacturer { get; init; }
    
    [JsonPropertyName("ManufacturerI18n")]
    public BoolFeature ManufacturerI18n { get; init; }
    
    [JsonPropertyName("Category")]
    public Feature<Category> Category { get; init; }
    
    [JsonPropertyName("CategoryI18n")]
    public BoolFeature CategoryI18n { get; init; }
    
    [JsonPropertyName("CategoryAttr")]
    public BoolFeature CategoryAttribute { get; init; }
    
    [JsonPropertyName("CategoryCustomerGroup")]
    public Feature<CategoryCustomerGroup> CategoryCustomerGroup { get; init; }
    
    [JsonPropertyName("CategoryInvisibility")]
    public Feature<CategoryInvisibility> CategoryInvisibility { get; init; }
    
    [JsonPropertyName("ConfigGroup")]
    public Feature<ConfigGroup> ConfigGroup { get; init; }
    
    [JsonPropertyName("ConfigGroupI18n")]
    public BoolFeature ConfigGroupI18n { get; init; }
    
    [JsonPropertyName("ConfigItem")]
    public Feature<ConfigItem> ConfigItem { get; init; }
    
    [JsonPropertyName("ConfigItemI18n")]
    public BoolFeature ConfigItemI18n { get; init; }
    
    [JsonPropertyName("ConfigItemPrice")]
    public Feature<ConfigItemPrice> ConfigItemPrice { get; init; }
    
    [JsonPropertyName("CrossSelling")]
    public Feature<CrossSelling> CrossSelling { get; init; }
    
    [JsonPropertyName("CrossSellingGroup")]
    public Feature<CrossSellingGroup> CrossSellingGroup { get; init; }
    
    [JsonPropertyName("CrossSellingGroupI18n")]
    public BoolFeature CrossSellingGroupI18n { get; init; }
    
    [JsonPropertyName("CrossSellingItem")]
    public Feature<CrossSellingItem> CrossSellingItem { get; init; }
    
    [JsonPropertyName("Currency")]
    public Feature<Currency> Currency { get; init; }
    
    [JsonPropertyName("Customer")]
    public Feature<Customer> Customer { get; init; }
    
    [JsonPropertyName("CustomerGroup")]
    public Feature<CustomerGroup> CustomerGroup { get; init; }
    
    [JsonPropertyName("CustomerGroupAttr")]
    public BoolFeature CustomerGroupAttr { get; init; }
    
    [JsonPropertyName("CustomerGroupI18n")]
    public BoolFeature CustomerGroupI18n { get; init; }
    
    [JsonPropertyName("CustomerGroupPackagingQuantity")]
    public Feature<CustomerGroupPackagingQuantity> CustomerGroupPackagingQuantity { get; init; }
    
    [JsonPropertyName("CustomerOrder")]
    public Feature<CustomerOrder> CustomerOrder { get; init; }
    
    [JsonPropertyName("CustomerOrderAttr")]
    public BoolFeature CustomerOrderAttr { get; init; }
    
    [JsonPropertyName("CustomerOrderBillingAddress")]
    public BoolFeature CustomerOrderBillingAddress { get; init; }
    
    [JsonPropertyName("CustomerOrderItem")]
    public BoolFeature CustomerOrderItem { get; init; }
    
    [JsonPropertyName("CustomerOrderItemVariation")]
    public BoolFeature CustomerOrderItemVariation { get; init; }
    
    [JsonPropertyName("CustomerOrderPaymentInfo")]
    public BoolFeature CustomerOrderPaymentInfo { get; init; }
    
    [JsonPropertyName("CustomerOrderShippingAddress")]
    public BoolFeature CustomerOrderShippingAddress { get; init; }
    
    [JsonPropertyName("DeliveryNote")]
    public Feature<DeliveryNote> DeliveryNote { get; init; }
    
    [JsonPropertyName("DeliveryNoteItem")]
    public BoolFeature DeliveryNoteItem { get; init; }
    
    [JsonPropertyName("DeliveryNoteItemInfo")]
    public BoolFeature DeliveryNoteItemInfo { get; init; }
    
    [JsonPropertyName("FileDownload")]
    public Feature<ProductFileDownload> FileDownload { get; init; }
    
    [JsonPropertyName("FileDownloadI18n")]
    public BoolFeature FileDownloadI18n { get; init; }
    
    [JsonPropertyName("FileUpload")]
    public Feature<FileUpload> FileUpload { get; init; }

    [JsonPropertyName("FileUploadI18n")]
    public BoolFeature FileUploadI18n { get; init; }
    
    [JsonPropertyName("Image")]
    public Feature<AbstractImage> Image { get; init; }
    
    [JsonPropertyName("Language")]
    public Feature<Language> Language { get; init; }
    
    [JsonPropertyName("MeasurementUnit")]
    public Feature<MeasurementUnit> MeasurementUnit { get; init; }
    
    [JsonPropertyName("MeasurementUnitI18n")]
    public BoolFeature MeasurementUnitI18n { get; init; }
    
    [JsonPropertyName("MediaFile")]
    public Feature<ProductMediaFile> MediaFile { get; init; }
    
    [JsonPropertyName("MediaFileAttr")]
    public BoolFeature MediaFileAttr { get; init; }
    
    [JsonPropertyName("MediaFileAttrI18n")]
    public BoolFeature MediaFileAttrI18n { get; init; }
    
    [JsonPropertyName("PartsList")]
    public Feature<PartsList> PartsList { get; init; }
    
    [JsonPropertyName("Payment")]
    public Feature<Payment> Payment { get; init; }
    
    [JsonPropertyName("Product")]
    public Feature<Product> Product { get; init; }
    
    [JsonPropertyName("Product2Category")]
    public BoolFeature Product2Category { get; init; }
    
    [JsonPropertyName("ProductAttr")]
    public BoolFeature ProductAttr { get; init; }
    
    [JsonPropertyName("ProductAttrI18n")]
    public BoolFeature ProductAttrI18n { get; init; }
    
    [JsonPropertyName("ProductConfigGroup")]
    public BoolFeature ProductConfigGroup { get; init; }
    
    [JsonPropertyName("ProductFileDownload")]
    public BoolFeature ProductFileDownload { get; init; }
    
    [JsonPropertyName("ProductI18n")]
    public BoolFeature ProductI18n { get; init; }
    
    [JsonPropertyName("ProductInvisibility")]
    public BoolFeature ProductInvisibility { get; init; }
    
    [JsonPropertyName("ProductPartsList")]
    public BoolFeature ProductPartsList { get; init; }
    
    [JsonPropertyName("ProductPrice")]
    public Feature<ProductPrice> ProductPrice { get; init; }
    
    [JsonPropertyName("ProductPriceItem")]
    public BoolFeature ProductPriceItem { get; init; }
    
    [JsonPropertyName("ProductSpecialPrice")]
    public BoolFeature ProductSpecialPrice { get; init; }
    
    [JsonPropertyName("ProductSpecialPriceItem")]
    public BoolFeature ProductSpecialPriceItem { get; init; }
    
    [JsonPropertyName("ProductSpecific")]
    public BoolFeature ProductSpecific { get; init; }
    
    [JsonPropertyName("ProductStockLevel")]
    public Feature<ProductStockLevel> ProductStockLevel { get; init; }
    
    [JsonPropertyName("ProductType")]
    public BoolFeature ProductType { get; init; }
    
    [JsonPropertyName("ProductVarCombination")]
    public BoolFeature ProductVarCombination { get; init; }
    
    [JsonPropertyName("ProductVariation")]
    public BoolFeature ProductVariation { get; init; }
    
    [JsonPropertyName("ProductVariationI18n")]
    public BoolFeature ProductVariationI18n { get; init; }
    
    [JsonPropertyName("ProductVariationInvisibility")]
    public BoolFeature ProductVariationInvisibility { get; init; }
    
    [JsonPropertyName("ProductVariationValue")]
    public BoolFeature ProductVariationValue { get; init; }
    
    [JsonPropertyName("ProductVariationValueDependency")]
    public BoolFeature ProductVariationValueDependency { get; init; }
    
    [JsonPropertyName("ProductVariationValueExtraCharge")]
    public BoolFeature ProductVariationValueExtraCharge { get; init; }
    
    [JsonPropertyName("ProductVariationValueI18n")]
    public BoolFeature ProductVariationValueI18n { get; init; }
    
    [JsonPropertyName("ProductVariationValueInvisibility")]
    public BoolFeature ProductVariationValueInvisibility { get; init; }
    
    [JsonPropertyName("ProductWarehouseInfo")]
    public BoolFeature ProductWarehouseInfo { get; init; }
    
    [JsonPropertyName("Shipment")]
    public BoolFeature Shipment { get; init; }
    
    [JsonPropertyName("ShippingClass")]
    public BoolFeature ShippingClass { get; init; }
    
    [JsonPropertyName("Specific")]
    public Feature<Specific> Specific { get; init; }
    
    [JsonPropertyName("SpecificI18n")]
    public BoolFeature SpecificI18n { get; init; }
    
    [JsonPropertyName("SpecificValue")]
    public BoolFeature SpecificValue { get; init; }
    
    [JsonPropertyName("SpecificValueI18n")]
    public BoolFeature SpecificValueI18n { get; init; }
    
    [JsonPropertyName("Statistic")]
    public BoolFeature Statistic { get; init; }
    
    [JsonPropertyName("StatusChange")]
    public Feature<StatusChange> StatusChange { get; init; }
    
    [JsonPropertyName("TaxClass")]
    public Feature<TaxClass> TaxClass { get; init; }
    
    [JsonPropertyName("TaxRate")]
    public Feature<TaxRate> TaxRate { get; init; }
    
    [JsonPropertyName("TaxZone")]
    public Feature<TaxZone> TaxZone { get; init; }
    
    [JsonPropertyName("TaxZoneCountry")]
    public BoolFeature TaxZoneCountry { get; init; }
    
    [JsonPropertyName("Unit")]
    public Feature<Unit> Unit { get; init; }
    
    [JsonPropertyName("UnitI18n")]
    public BoolFeature UnitI18n { get; init; }
    
    [JsonPropertyName("Warehouse")]
    public Feature<Warehouse> Warehouse { get; init; }
}