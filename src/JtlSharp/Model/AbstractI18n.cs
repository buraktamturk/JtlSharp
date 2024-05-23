using System.Text.Json.Serialization;
using JtlSharp;
using NLanguageTag;

namespace Jtl.Connector.Core.Model;

public record AbstractI18n : AbstractModel
{
    private string? tag3;

    /// <summary>
    /// string
    /// </summary>
    [JsonPropertyName("languageIso")]
    public string? languageIso2
    {
        get
        {
            return tag3 == null ? null : IsoConverter.From3To2(tag3);
        }
        init
        {
            tag3 = IsoConverter.From2To3(value);
        }
    }

    [JsonPropertyName("languageISO")]
    public string? languageISO3
    {
        get => tag3;
        init => tag3 = value;
    }
}

