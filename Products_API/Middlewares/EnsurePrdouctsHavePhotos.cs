
using Microsoft.EntityFrameworkCore;
using Polly.Registry;
using Products_API.BusinessModels.Unsplash;
using Products_API.Data;
using Products_API.Services;

namespace Products_API.Middlewares;

public class EnsurePrdouctsHavePhotos : IMiddleware
{
    private readonly IUnsplashService _unsplashService;
    private readonly ShopContext _context;

    public EnsurePrdouctsHavePhotos(IUnsplashService unsplashService,
        ShopContext context)
    {
        _unsplashService = unsplashService;
        _context = context;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var productsWithNoPhotos = _context.Set<Product>()
            .Where(p => string.IsNullOrWhiteSpace(p.Photo));

        foreach (var product in productsWithNoPhotos)
        {
            product.Photo = await _unsplashService.GetRandomPhotoUrl(product.Name);
        }

        await _context.SaveChangesAsync();
        await next(context);
    }
}
