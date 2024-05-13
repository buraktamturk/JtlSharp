namespace Jtl.Connector.Core.Model;

public record DeliveryNoteTrackingList : AbstractModel
{
    /// <summary>
    /// string
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public IReadOnlyCollection<string>? codes { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public IReadOnlyCollection<string>? trackingURLs { get; init; }

}

