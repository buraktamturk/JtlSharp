using System.Text.Json;
using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp.Converter;

public class ProductStockLevelConverter : JsonConverter<ProductStockLevel?>
{
    public override ProductStockLevel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType == JsonTokenType.StartObject)
            return JsonSerializer.Deserialize<ProductStockLevel>(ref reader);

        if (reader.TokenType == JsonTokenType.Number)
            return new ProductStockLevel { stockLevel = reader.GetDecimal() };
        
        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, ProductStockLevel? value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartObject();
        writer.WriteNumber("stockLevel", value.stockLevel.Value);
        writer.WriteEndObject();
    }
}