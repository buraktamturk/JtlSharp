using System.Text.Json.Serialization;
using JtlSharp.Converter;

namespace Jtl.Connector.Core.Model;

public record ProductStockLevel : AbstractModel
{
    /// <summary>
    /// Identity
    /// </summary>
    [JsonConverter(typeof(IdentityConverter))]
    public Identity? productId { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? stockLevel { get; init; }

}

