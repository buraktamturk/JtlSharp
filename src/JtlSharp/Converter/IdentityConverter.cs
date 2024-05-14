using System.Text.Json;
using System.Text.Json.Serialization;
using Jtl.Connector.Core.Model;

namespace JtlSharp.Converter;

public class IdentityConverter : JsonConverter<Identity?>
{
    public override Identity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;
        
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        reader.Read();
        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException();
        
        var endpoint = reader.GetString();
        
        reader.Read();
        
        if (reader.TokenType != JsonTokenType.Number)
            throw new JsonException();
        
        var host = reader.GetInt32();
        
        reader.Read();
        
        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();
        
        return new Identity
        {
            endpoint = endpoint,
            host = host
        };
    }

    public override void Write(Utf8JsonWriter writer, Identity? value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStartArray();
        writer.WriteStringValue(value.endpoint);
        writer.WriteNumberValue(value.host.Value);
        writer.WriteEndArray();
    }
}