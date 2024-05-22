using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public record BoolFeature
{
    [JsonPropertyName("pull")]
    public bool Pull { get; init; }

    [JsonPropertyName("push")]
    public bool Push { get; init; }

    [JsonPropertyName("delete")]
    public bool Delete { get; init; }
}

public record AckBoolFeature : IAckFeature
{
    [JsonIgnore]
    public Func<IReadOnlyCollection<Identity>, bool, Task>? Ack { get; init; }

    [JsonPropertyName("pull")]
    public bool Pull => Ack is not null;

    [JsonPropertyName("push")]
    public bool Push { get; init; }

    [JsonPropertyName("delete")]
    public bool Delete { get; init; }
}
