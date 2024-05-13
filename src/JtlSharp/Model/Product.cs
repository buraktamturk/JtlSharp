namespace Jtl.Connector.Core.Model;

public record Product : AbstractIdentity
{
    /// <summary>
    /// Identity Optional reference to basePriceUnit
    /// </summary>
    public Identity? basePriceUnitId { get; init; }

    /// <summary>
    /// Identity Reference to manufacturer
    /// </summary>
    public Identity? manufacturerId { get; init; }

    /// <summary>
    /// Identity Reference to master product
    /// </summary>
    public Identity? masterProductId { get; init; }

    /// <summary>
    /// Identity Optional reference to measurement unit id
    /// </summary>
    public Identity? measurementUnitId { get; init; }

    /// <summary>
    /// Identity Optional reference to partsList
    /// </summary>
    public Identity? partsListId { get; init; }

    /// <summary>
    /// Identity Optional reference to productType
    /// </summary>
    public Identity? productTypeId { get; init; }

    /// <summary>
    /// Identity Reference to shippingClass
    /// </summary>
    public Identity? shippingClassId { get; init; }

    /// <summary>
    /// Identity Reference to tax class
    /// </summary>
    public Identity? taxClassId { get; init; }

    /// <summary>
    /// Identity Reference to unit
    /// </summary>
    public Identity? unitId { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? additionalHandlingTime { get; init; }

    /// <summary>
    /// string Optional Amazon Standard Identification Number
    /// </summary>
    public string? asin { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Optional available from date. Specify a date, upon when product can be purchased
    /// </summary>
    public DateTimeOffset? availableFrom { get; init; }

    /// <summary>
    /// double Optional base price divisor.
     /// Calculate basePriceDivisor by dividing product filling quantity through unit pricing base measure.
     /// E.g. 75ml / 100ml = 0.75
    /// </summary>
    public decimal? basePriceDivisor { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? basePriceFactor { get; init; }

    /// <summary>
    /// double Optional base price quantity
    /// </summary>
    public decimal? basePriceQuantity { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? basePriceUnitCode { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? basePriceUnitName { get; init; }

    /// <summary>
    /// boolean Optional: Set to true to display base price / unit pricing measure
    /// </summary>
    public bool? considerBasePrice { get; init; }

    /// <summary>
    /// boolean Consider stock level?
     /// If true, product can only be purchased with a positive stockLevel or when permitNegativeStock is set to true
    /// </summary>
    public bool? considerStock { get; init; }

    /// <summary>
    /// boolean Optional: Consider stock levels of productVariations. Same as considerStock but for variations
    /// </summary>
    public bool? considerVariationStock { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Creation date
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? discountable { get; init; }

    /// <summary>
    /// string Optional European Article Number (EAN
    /// </summary>
    public string? ean { get; init; }

    /// <summary>
    /// string Optional Ebay product ID
    /// </summary>
    public string? epid { get; init; }

    /// <summary>
    /// string Optional Hazard identifier, encodes general hazard class und subdivision
    /// </summary>
    public string? hazardIdNumber { get; init; }

    /// <summary>
    /// double Optional product height
    /// </summary>
    public decimal? height { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? isActive { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? isBatch { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? isBestBefore { get; init; }

    /// <summary>
    /// string Optional International Standard Book Number
    /// </summary>
    public string? isbn { get; init; }

    /// <summary>
    /// boolean Optional: Set to true to allow non-integer quantites for purchase
    /// </summary>
    public bool? isDivisible { get; init; }

    /// <summary>
    /// boolean Optional flag if product is master product
    /// </summary>
    public bool? isMasterProduct { get; init; }

    /// <summary>
    /// boolean Optional flag new product.
     /// If true, product will be highlighted as new (creation date may also be considered
    /// </summary>
    public bool? isNewProduct { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? isSerialNumber { get; init; }

    /// <summary>
    /// boolean Optional flag top product.
     /// If true, product will be highlighted as top product (e.g. in product lists or in special boxes
    /// </summary>
    public bool? isTopProduct { get; init; }

    /// <summary>
    /// string Optional internal keywords and synonyms for product
    /// </summary>
    public string? keywords { get; init; }

    /// <summary>
    /// double Optional product length
    /// </summary>
    public decimal? length { get; init; }

    /// <summary>
    /// string Optional manufacturer number
    /// </summary>
    public string? manufacturerNumber { get; init; }

    /// <summary>
    /// Manufacturer|null
    /// </summary>
    public Manufacturer? manufacturer { get; init; }

    /// <summary>
    /// double Optional measurement quantity
    /// </summary>
    public decimal? measurementQuantity { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? measurementUnitCode { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? minBestBeforeDate { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? minimumOrderQuantity { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? minimumQuantity { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? modified { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? newReleaseDate { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Contains the date of the next available inflow
    /// </summary>
    public DateTimeOffset? nextAvailableInflowDate { get; init; }

    /// <summary>
    /// double Contains the quantity of the next available inflow
    /// </summary>
    public decimal? nextAvailableInflowQuantity { get; init; }

    /// <summary>
    /// string Optional internal product note
    /// </summary>
    public string? note { get; init; }

    /// <summary>
    /// string Optional Origin country
    /// </summary>
    public string? originCountry { get; init; }

    /// <summary>
    /// double Optional: self can only be purchased in multiples of takeOffQuantity e.g. 5,10,15
    /// </summary>
    public decimal? packagingQuantity { get; init; }

    /// <summary>
    /// boolean Optional Permit negative stock / allow overselling.
     /// If true, product can be purchased even if stockLevel is less or equal 0 and considerStock is true
    /// </summary>
    public bool? permitNegativeStock { get; init; }

    /// <summary>
    /// double Productweight exclusive packaging
    /// </summary>
    public decimal? productWeight { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? purchasePrice { get; init; }

    /// <summary>
    /// double Optional recommended retail price (gross
    /// </summary>
    public decimal? recommendedRetailPrice { get; init; }

    /// <summary>
    /// string Optional serial number
    /// </summary>
    public string? serialNumber { get; init; }

    /// <summary>
    /// double Productweight inclusive packaging
    /// </summary>
    public decimal? shippingWeight { get; init; }

    /// <summary>
    /// string Optional stock keeping unit identifier
    /// </summary>
    public string? sku { get; init; }

    /// <summary>
    /// integer Optional sort number for product sorting in lists
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? stockLevel { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? supplierDeliveryTime { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? supplierStockLevel { get; init; }

    /// <summary>
    /// string Optional TARIC
    /// </summary>
    public string? taric { get; init; }

    /// <summary>
    /// string Optional UN number, used to define hazardous properties
    /// </summary>
    public string? unNumber { get; init; }

    /// <summary>
    /// string Optional Universal Product Code
    /// </summary>
    public string? upc { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? vat { get; init; }

    /// <summary>
    /// double Optional product width
    /// </summary>
    public decimal? width { get; init; }

    /// <summary>
    /// ProductAttribute
    /// </summary>
    public IReadOnlyCollection<ProductAttribute>? attributes { get; init; }

    /// <summary>
    /// Product2Category
    /// </summary>
    public IReadOnlyCollection<Product2Category>? categories { get; init; }

    /// <summary>
    /// ProductChecksum
    /// </summary>
    public IReadOnlyCollection<ProductChecksum>? checksums { get; init; }

    /// <summary>
    /// ProductConfigGroup
    /// </summary>
    public IReadOnlyCollection<ProductConfigGroup>? configGroups { get; init; }

    /// <summary>
    /// CustomerGroupPackagingQuantity
    /// </summary>
    public IReadOnlyCollection<CustomerGroupPackagingQuantity>? customerGroupPackagingQuantities { get; init; }

    /// <summary>
    /// ProductFileDownload
    /// </summary>
    public IReadOnlyCollection<ProductFileDownload>? fileDownloads { get; init; }

    /// <summary>
    /// ProductI18n
    /// </summary>
    public IReadOnlyCollection<ProductI18n>? i18ns { get; init; }

    /// <summary>
    /// ProductInvisibility
    /// </summary>
    public IReadOnlyCollection<ProductInvisibility>? invisibilities { get; init; }

    /// <summary>
    /// ProductMediaFile
    /// </summary>
    public IReadOnlyCollection<ProductMediaFile>? mediaFiles { get; init; }

    /// <summary>
    /// ProductPartsList
    /// </summary>
    public IReadOnlyCollection<ProductPartsList>? partsLists { get; init; }

    /// <summary>
    /// ProductPrice
    /// </summary>
    public IReadOnlyCollection<ProductPrice>? prices { get; init; }

    /// <summary>
    /// ProductSpecialPrice
    /// </summary>
    public IReadOnlyCollection<ProductSpecialPrice>? specialPrices { get; init; }

    /// <summary>
    /// ProductSpecific
    /// </summary>
    public IReadOnlyCollection<ProductSpecific>? specifics { get; init; }

    /// <summary>
    /// array<TaxRate
    /// </summary>
    public IReadOnlyCollection<TaxRate>? taxRates { get; init; }

    /// <summary>
    /// ProductVariation
    /// </summary>
    public IReadOnlyCollection<ProductVariation>? variations { get; init; }

    /// <summary>
    /// ProductWarehouseInfo
    /// </summary>
    public IReadOnlyCollection<ProductWarehouseInfo>? warehouseInfo { get; init; }

}

