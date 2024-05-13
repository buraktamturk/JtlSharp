namespace Jtl.Connector.Core.Model;

public record MeasurementUnit : AbstractIdentity
{
    /// <summary>
    /// string Optional UCUM-Code, see  http://unitsofmeasure.org
    /// </summary>
    public string? code { get; init; }

    /// <summary>
    /// string Synonym e.g. 'ml
    /// </summary>
    public string? displayCode { get; init; }

    /// <summary>
    /// MeasurementUnitI18n
    /// </summary>
    public IReadOnlyCollection<MeasurementUnitI18n>? i18ns { get; init; }

}

