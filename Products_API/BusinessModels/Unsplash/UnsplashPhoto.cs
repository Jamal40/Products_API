using System.Text.Json.Serialization;

namespace Products_API.BusinessModels.Unsplash;

public class Photo
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("urls")]
    public Urls Urls { get; set; } = new();
}

