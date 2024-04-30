using Microsoft.EntityFrameworkCore;
using Products_API.Data;

namespace Products_API.Endpoints;

public static class CategoriesEndpoints
{
    public static void MapCategoryEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Categories")
            .WithTags("Category");

        group.MapGet("/", async (ShopContext db) =>
        {
            return await db.Products
                .Select(p => new
                {
                    Id = $"{p.Category}_{Guid.NewGuid()}",
                    Name = p.Category
                })
                .Distinct()
                .ToListAsync();
        })
        .WithName("GetAllCategories")
        .WithOpenApi()
        .RequireAuthorization();
    }
}

