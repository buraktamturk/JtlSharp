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
    public Feature<ProductType> ProductType { get; init; }
    
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
    public Feature<ShippingClass> ShippingClass { get; init; }
    
    [JsonPropertyName("ShippingMethod")]
    public Feature<ShippingMethod> ShippingMethod { get; init; }
    
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

public static class EntitiesExtensions
{
    public static IAckFeature GetAckFeature(this Entities entities, string type)
    {
        return type switch
        {
            "Manufacturer" => (IAckFeature)entities.Manufacturer,
            "ManufacturerI18n" => (IAckFeature)entities.ManufacturerI18n,
            "Category" => (IAckFeature)entities.Category,
            "CategoryI18n" => (IAckFeature)entities.CategoryI18n,
            "CategoryAttr" => (IAckFeature)entities.CategoryAttribute,
            "CategoryCustomerGroup" => (IAckFeature)entities.CategoryCustomerGroup,
            "CategoryInvisibility" => (IAckFeature)entities.CategoryInvisibility,
            "ConfigGroup" => (IAckFeature)entities.ConfigGroup,
            "ConfigGroupI18n" => (IAckFeature)entities.ConfigGroupI18n,
            "ConfigItem" => (IAckFeature)entities.ConfigItem,
            "ConfigItemI18n" => (IAckFeature)entities.ConfigItemI18n,
            "ConfigItemPrice" => (IAckFeature)entities.ConfigItemPrice,
            "CrossSelling" => (IAckFeature)entities.CrossSelling,
            "CrossSellingGroup" => (IAckFeature)entities.CrossSellingGroup,
            "CrossSellingGroupI18n" => (IAckFeature)entities.CrossSellingGroupI18n,
            "CrossSellingItem" => (IAckFeature)entities.CrossSellingItem,
            "Currency" => (IAckFeature)entities.Currency,
            "Customer" => (IAckFeature)entities.Customer,
            "CustomerGroup" => (IAckFeature)entities.CustomerGroup,
            "CustomerGroupAttr" => (IAckFeature)entities.CustomerGroupAttr,
            "CustomerGroupI18n" => (IAckFeature)entities.CustomerGroupI18n,
            "CustomerGroupPackagingQuantity" => (IAckFeature)entities.CustomerGroupPackagingQuantity,
            "CustomerOrder" => (IAckFeature)entities.CustomerOrder,
            "CustomerOrderAttr" => (IAckFeature)entities.CustomerOrderAttr,
            "CustomerOrderBillingAddress" => (IAckFeature)entities.CustomerOrderBillingAddress,
            "CustomerOrderItem" => (IAckFeature)entities.CustomerOrderItem,
            "CustomerOrderItemVariation" => (IAckFeature)entities.CustomerOrderItemVariation,
            "CustomerOrderPaymentInfo" => (IAckFeature)entities.CustomerOrderPaymentInfo,
            "CustomerOrderShippingAddress" => (IAckFeature)entities.CustomerOrderShippingAddress,
            "DeliveryNote" => (IAckFeature)entities.DeliveryNote,
            "DeliveryNoteItem" => (IAckFeature)entities.DeliveryNoteItem,
            "DeliveryNoteItemInfo" => (IAckFeature)entities.DeliveryNoteItemInfo,
            "FileDownload" => (IAckFeature)entities.FileDownload,
            "FileDownloadI18n" => (IAckFeature)entities.FileDownloadI18n,
            "FileUpload" => (IAckFeature)entities.FileUpload,
            "FileUploadI18n" => (IAckFeature)entities.FileUploadI18n,
            "Image" => (IAckFeature)entities.Image,
            "Language" => (IAckFeature)entities.Language,
            "MeasurementUnit" => (IAckFeature)entities.MeasurementUnit,
            "MeasurementUnitI18n" => (IAckFeature)entities.MeasurementUnitI18n,
            "MediaFile" => (IAckFeature)entities.MediaFile,
            "MediaFileAttr" => (IAckFeature)entities.MediaFileAttr,
            "MediaFileAttrI18n" => (IAckFeature)entities.MediaFileAttrI18n,
            "PartsList" => (IAckFeature)entities.PartsList,
            "Payment" => (IAckFeature)entities.Payment,
            "Product" => (IAckFeature)entities.Product,
            "Product2Category" => (IAckFeature)entities.Product2Category,
            "ProductAttr" => (IAckFeature)entities.ProductAttr,
            "ProductAttrI18n" => (IAckFeature)entities.ProductAttrI18n,
            "ProductConfigGroup" => (IAckFeature)entities.ProductConfigGroup,
            "ProductFileDownload" => (IAckFeature)entities.ProductFileDownload,
            "ProductI18n" => (IAckFeature)entities.ProductI18n,
            "ProductInvisibility" => (IAckFeature)entities.ProductInvisibility,
            "ProductPartsList" => (IAckFeature)entities.ProductPartsList,
            "ProductPrice" => (IAckFeature)entities.ProductPrice,
            "ProductPriceItem" => (IAckFeature)entities.ProductPriceItem,
            "ProductSpecialPrice" => (IAckFeature)entities.ProductSpecialPrice,
            "ProductSpecialPriceItem" => (IAckFeature)entities.ProductSpecialPriceItem,
            "ProductSpecific" => (IAckFeature)entities.ProductSpecific,
            "ProductStockLevel" => (IAckFeature)entities.ProductStockLevel,
            "ProductType" => (IAckFeature)entities.ProductType,
            "ProductVarCombination" => (IAckFeature)entities.ProductVarCombination,
            "ProductVariation" => (IAckFeature)entities.ProductVariation,
            "ProductVariationI18n" => (IAckFeature)entities.ProductVariationI18n,
            "ProductVariationInvisibility" => (IAckFeature)entities.ProductVariationInvisibility,
            "ProductVariationValue" => (IAckFeature)entities.ProductVariationValue,
            "ProductVariationValueDependency" => (IAckFeature)entities.ProductVariationValueDependency,
            "ProductVariationValueExtraCharge" => (IAckFeature)entities.ProductVariationValueExtraCharge,
            "ProductVariationValueI18n" => (IAckFeature)entities.ProductVariationValueI18n,
            "ProductVariationValueInvisibility" => (IAckFeature)entities.ProductVariationValueInvisibility,
            "ProductWarehouseInfo" => (IAckFeature)entities.ProductWarehouseInfo,
            "Shipment" => (IAckFeature)entities.Shipment,
            "ShippingClass" => (IAckFeature)entities.ShippingClass,
            "ShippingMethod" => (IAckFeature)entities.ShippingMethod,
            "Specific" => (IAckFeature)entities.Specific,
            "SpecificI18n" => (IAckFeature)entities.SpecificI18n,
            "SpecificValue" => (IAckFeature)entities.SpecificValue,
            "SpecificValueI18n" => (IAckFeature)entities.SpecificValueI18n,
            "Statistic" => (IAckFeature)entities.Statistic,
            "StatusChange" => (IAckFeature)entities.StatusChange,
            "TaxClass" => (IAckFeature)entities.TaxClass,
            "TaxRate" => (IAckFeature)entities.TaxRate,
            "TaxZone" => (IAckFeature)entities.TaxZone,
            "TaxZoneCountry" => (IAckFeature)entities.TaxZoneCountry,
            "Unit" => (IAckFeature)entities.Unit,
            "UnitI18n" => (IAckFeature)entities.UnitI18n,
            "Warehouse" => (IAckFeature)entities.Warehouse,
            _ => throw new NotImplementedException()
        };
    }

    public static async Task<bool> ProcessAck(this Entities entities, Ack ack, bool isClear = false)
    {
        foreach (var (key, value) in ack.identities)
        {
            await entities.GetAckFeature(key).Ack?.Invoke(value, false);
        }

        return true;
    }
}
