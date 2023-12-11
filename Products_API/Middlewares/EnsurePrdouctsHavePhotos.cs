
using Microsoft.EntityFrameworkCore;
using Polly.Registry;
using Products_API.BusinessModels.Unsplash;
using Products_API.Data;
using Products_API.Services;

namespace Products_API.Middlewares;

public class EnsurePrdouctsHavePhotos : IMiddleware
{
    private readonly IUnsplashService _unsplashService;
    private readonly ResiliencePipelineProvider<string> _pipelineProvider;
    private readonly ShopContext _context;

    public EnsurePrdouctsHavePhotos(IUnsplashService unsplashService,
        ResiliencePipelineProvider<string> pipelineProvider,
        ShopContext context)
    {
        _unsplashService = unsplashService;
        _pipelineProvider = pipelineProvider;
        _context = context;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var productsWithNoPhotos = _context.Set<Product>()
            .Where(p => string.IsNullOrWhiteSpace(p.Photo));

        var pipeline = _pipelineProvider.GetPipeline<string>(
            Constants.Policies.UnsplashFallback);
        foreach (var product in productsWithNoPhotos)
        {
            product.Photo = await pipeline.ExecuteAsync(
                async _ => await _unsplashService.GetRandomPhotoUrl(product.Name));
        }

        await _context.SaveChangesAsync();
        await next(context);
    }
}
