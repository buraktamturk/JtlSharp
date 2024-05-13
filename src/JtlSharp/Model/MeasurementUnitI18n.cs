namespace Jtl.Connector.Core.Model;

public record MeasurementUnitI18n : AbstractI18n
{
    /// <summary>
    /// string Localized Name
    /// </summary>
    public string? name { get; init; }

}

