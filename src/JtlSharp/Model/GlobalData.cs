namespace Jtl.Connector.Core.Model;

public record GlobalData : AbstractModel
{
    /// <summary>
    /// ConfigGroup
    /// </summary>
    public IReadOnlyCollection<ConfigGroup>? configGroups { get; init; }

    /// <summary>
    /// ConfigItem
    /// </summary>
    public IReadOnlyCollection<ConfigItem>? configItems { get; init; }

    /// <summary>
    /// CrossSellingGroup
    /// </summary>
    public IReadOnlyCollection<CrossSellingGroup>? crossSellingGroups { get; init; }

    /// <summary>
    /// Currency
    /// </summary>
    public IReadOnlyCollection<Currency>? currencies { get; init; }

    /// <summary>
    /// CustomerGroup
    /// </summary>
    public IReadOnlyCollection<CustomerGroup>? customerGroups { get; init; }

    /// <summary>
    /// Language
    /// </summary>
    public IReadOnlyCollection<Language>? languages { get; init; }

    /// <summary>
    /// MeasurementUnit
    /// </summary>
    public IReadOnlyCollection<MeasurementUnit>? measurementUnits { get; init; }

    /// <summary>
    /// ProductType
    /// </summary>
    public IReadOnlyCollection<ProductType>? productTypes { get; init; }

    /// <summary>
    /// ShippingClass
    /// </summary>
    public IReadOnlyCollection<ShippingClass>? shippingClasses { get; init; }

    /// <summary>
    /// ShippingMethod
    /// </summary>
    public IReadOnlyCollection<ShippingMethod>? shippingMethods { get; init; }

    /// <summary>
    /// TaxRate
    /// </summary>
    public IReadOnlyCollection<TaxRate>? taxRates { get; init; }

    /// <summary>
    /// Unit
    /// </summary>
    public IReadOnlyCollection<Unit>? units { get; init; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse>? warehouses { get; init; }

}

