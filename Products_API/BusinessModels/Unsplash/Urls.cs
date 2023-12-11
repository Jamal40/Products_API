using System.Text.Json.Serialization;

namespace Products_API.BusinessModels.Unsplash;

public class Urls
{
    [JsonPropertyName("regular")]
    public string Regular { get; set; } = string.Empty;
}