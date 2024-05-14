using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JtlSharp.Converter;

public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
{
    public override DateTimeOffset? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // parse 0001-01-01T00:00:00\u002B01:00
        if (reader.TokenType == JsonTokenType.Null)
            return null;
        
        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException();

        var str = reader.GetString();
        if (str.StartsWith("0001"))
            return null;
        
        return DateTimeOffset.ParseExact(str, "yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset? value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            writer.WriteNullValue();
            return;
        }
        
        writer.WriteStringValue(value.Value.ToString("yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture));
    }
}