using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp;

public interface IJtlService
{
    Feature GetFeatures();
}

public record Feature
{
    [JsonPropertyName("entities")]
    public Entities Entities { get; init; }
    
    [JsonPropertyName("flags")]
    public FeatureFlags Flags { get; init; }
}

public record Entities
{
    [JsonPropertyName("Category")]
    public Feature<Category> Category { get; init; }
    
    [JsonPropertyName("Product")]
    public Feature<Product> Product { get; init; }
}

public record FeatureFlags
{
    public bool can_reactivate_customer_order { get; init; }
    
    public bool can_update_customer_order { get; init; }
    
    public bool category_images_supported { get; init; }
    
    public bool config_group_images_supported { get; init; }
    
    public bool customer_order_partially_payable { get; init; }
    
    public bool free_field_supported { get; init; }
    
    public bool manufacturer_images_supported { get; init; }
    
    public bool needs_finish_call { get; init; }
    
    public bool product_images_supported { get; init; }
    
    public bool product_variation_value_images_supported { get; init; }
    
    public bool set_articles_supported { get; init; }
    
    public bool specific_images_supported { get; init; }
    
    public bool specific_value_images_supported { get; init; }
    
    public bool var_combination_child_first { get; init; }
    
    public bool variation_combinations_supported { get; init; }
    
    public bool variation_products_supported { get; init; }
    
    public bool send_all_acks { get; init; }
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
