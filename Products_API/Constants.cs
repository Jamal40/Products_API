namespace Products_API;

public static class Constants
{
    public static class Policies
    {
        public const string AllowAll = "AllowAll";
        public const string UnsplashFallback = "UnsplashFallback";
    }

    public static class Headers
    {
        public const string Authorization = "Authorization";
        public const string UnsplashAuthValue = "Client-ID {0}";
    }

    public static class Endpoints
    {
        public const string UnsplashBaseUri = "UnsplashBaseUri";
    }

    public static class ConfigurationKeys
    {
        public const string UnsplashApiKey = "UnsplashApiKey";
    }

    public static class ConnectionStrings
    {
        public const string ShopDb = "ShopDb";
    }
}
