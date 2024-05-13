namespace Jtl.Connector.Core.Model;

public record Payment : AbstractIdentity
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? customerOrderId { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? billingInfo { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? paymentModuleCode { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? totalSum { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? transactionId { get; init; }

}

