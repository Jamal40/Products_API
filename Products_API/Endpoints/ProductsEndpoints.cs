using Microsoft.EntityFrameworkCore;
using Products_API.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Products_API.Services;

namespace Products_API.Endpoints;

public static class ProductsEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Products")
            .WithTags(nameof(Product));

        group.MapGet("/", async (ShopContext db) =>
        {
            return await db.Products.ToListAsync();
        })
        .WithName("GetAllProducts")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Product>, NotFound>> (Guid id, ShopContext db) =>
        {
            return await db.Products.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Product model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetProductById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (Guid id, Product product, ShopContext db) =>
        {
            var affected = await db.Products
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, product.Id)
                  .SetProperty(m => m.Name, product.Name)
                  .SetProperty(m => m.Category, product.Category.GetCategoryFromId())
                  .SetProperty(m => m.Price, product.Price)
                  .SetProperty(m => m.QuantityInStock, product.QuantityInStock)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateProduct")
        .WithOpenApi();

        group.MapPost("/", async (Product product, ShopContext db) =>
        {
            product.Category = product.Category.GetCategoryFromId();
            db.Products.Add(product);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Product/{product.Id}", product);
        })
        .WithName("CreateProduct")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (Guid id, ShopContext db) =>
        {
            var affected = await db.Products
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteProduct")
        .WithOpenApi();

        group.MapGet("/Photo/Random/{query}", async Task<Ok<string>> (string query,
            IUnsplashService unsplashService) =>
        {
            var photo = await unsplashService.GetRandomPhotoUrl(query);
            return TypedResults.Ok(photo);
        })
        .WithName("GetRandomPhoto")
        .WithOpenApi();
    }

    private static string GetCategoryFromId(this string categoryId)
        => categoryId.Split('_')[0];

}