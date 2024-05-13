namespace Jtl.Connector.Core.Model;

public record StatusChange : AbstractModel
{
    /// <summary>
    /// Identity
    /// </summary>
    public Identity? customerOrderId { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? orderStatus { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? paymentStatus { get; init; }

}

