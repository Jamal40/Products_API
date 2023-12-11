using Products_API.BusinessModels.Unsplash;

namespace Products_API.Services;

public interface IUnsplashService
{
    Task<string> GetRandomPhotoUrl(string? query = null);
}
