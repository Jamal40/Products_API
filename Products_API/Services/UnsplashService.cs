using Products_API.BusinessModels.Unsplash;

namespace Products_API.Services;

public class UnsplashService : IUnsplashService
{
    private readonly HttpClient _client;

    public UnsplashService(HttpClient client)
    {
        _client = client;
    }

    #region Random Photo

    public async Task<string> GetRandomPhotoUrl(string? query = null)
    {
        var endpoint = "photos/random" + GetQueryStringPartForRandomPhoto(query);
        var photo = await _client.GetFromJsonAsync<Photo>(endpoint);
        return photo?.Urls.Regular ?? string.Empty;
    }

    private string GetQueryStringPartForRandomPhoto(string? query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return string.Empty;
        return $"?query={Uri.EscapeDataString(query)}";
    }

    #endregion
}
