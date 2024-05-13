namespace Jtl.Connector.Core.Model;

public record CustomerOrder : AbstractI18n
{
    /// <summary>
    /// Identity Optional reference to customer
    /// </summary>
    public Identity? customerId { get; init; }

    /// <summary>
    /// Identity Unique customerOrder id
    /// </summary>
    public Identity? id { get; init; }

    /// <summary>
    /// CustomerOrderBillingAddress|null Billing address
    /// </summary>
    public CustomerOrderBillingAddress? billingAddress { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? carrierName { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Date of creation
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? currencyIso { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? customerNote { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? estimatedDeliveryDate { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? note { get; init; }

    /// <summary>
    /// string Optional order number (usually set by ERP System later
    /// </summary>
    public string? orderNumber { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Payment date
    /// </summary>
    public DateTimeOffset? paymentDate { get; init; }

    /// <summary>
    /// CustomerOrderPaymentInfo|null
    /// </summary>
    public CustomerOrderPaymentInfo? paymentInfo { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? paymentModuleCode { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? paymentStatus { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? pui { get; init; }

    /// <summary>
    /// CustomerOrderShippingAddress|null Shipping address
    /// </summary>
    public CustomerOrderShippingAddress? shippingAddress { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Shipping date
    /// </summary>
    public DateTimeOffset? shippingDate { get; init; }

    /// <summary>
    /// string Additional shipping info
    /// </summary>
    public string? shippingInfo { get; init; }

    /// <summary>
    /// Identity Optional reference to customer
    /// </summary>
    public Identity? shippingMethodId { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? shippingMethodName { get; init; }

    /// <summary>
    /// string Shipping status
    /// </summary>
    public string? status { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? totalSum { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? totalSumGross { get; init; }

    /// <summary>
    /// KeyValueAttribute
    /// </summary>
    public IReadOnlyCollection<KeyValueAttribute>? attributes { get; init; }

    /// <summary>
    /// CustomerOrderItem
    /// </summary>
    public IReadOnlyCollection<CustomerOrderItem>? items { get; init; }

}

