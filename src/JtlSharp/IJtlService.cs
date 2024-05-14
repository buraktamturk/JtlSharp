using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public interface IJtlService
{
    Feature GetFeatures();
}

public record Feature<T>
    where T : AbstractModel
{
    [JsonIgnore]
    public Func<QueryFilter, IAsyncEnumerable<T>>? Pull { get; init; }
    
    [JsonIgnore]
    public Func<T, Task<T>>? Push { get; init; }
    
    [JsonIgnore]
    public Func<Identities, Task>? Delete { get; init; }
    
    [JsonIgnore]
    public Func<Task<int>>? Statistics { get; init; }
    
    [JsonPropertyName("pull")]
    public bool PullSupported => Pull is not null;
    
    [JsonPropertyName("push")]
    public bool PushSupported => Push is not null;
    
    [JsonPropertyName("delete")]
    public bool DeleteSupported => Delete is not null;
}
