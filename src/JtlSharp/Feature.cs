using System.Text.Json.Serialization;

namespace JtlSharp;

public record Feature
{
    [JsonPropertyName("entities")]
    public Entities Entities { get; init; }
    
    [JsonPropertyName("flags")]
    public FeatureFlags Flags { get; init; }
}