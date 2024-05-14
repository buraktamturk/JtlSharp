namespace JtlSharp;

public record BoolFeature
{
    public bool Pull { get; init; }

    public bool Push { get; init; }

    public bool Delete { get; init; }
}