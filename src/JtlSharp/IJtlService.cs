using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public interface IJtlService
{
    Feature GetFeatures();
    
    ValueTask<ConnectorIdentification> Identify();

    Task<bool> Clear();
}

public interface IAckFeature
{
    Func<IReadOnlyCollection<Identity>, bool, Task>? Ack { get; init; }
}

public record Feature<T> : IAckFeature
    where T : AbstractModel
{
    [JsonIgnore]
    public Func<QueryFilter, IAsyncEnumerable<T>>? Pull { get; init; }
    
    [JsonIgnore]
    public Func<IReadOnlyCollection<Identity>, bool, Task>? Ack { get; init; }
    
    [JsonIgnore]
    public Func<T, Task<T>>? Push { get; init; }
    
    [JsonIgnore]
    public Func<IReadOnlyCollection<Identity>, Task>? Delete { get; init; }
    
    [JsonIgnore]
    public Func<Task<int>>? Statistics { get; init; }
    
    [JsonPropertyName("pull")]
    public bool PullSupported => Pull is not null;
    
    [JsonPropertyName("push")]
    public bool PushSupported => Push is not null;
    
    [JsonPropertyName("delete")]
    public bool DeleteSupported => Delete is not null;
}
