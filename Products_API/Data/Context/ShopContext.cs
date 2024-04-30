using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Products_API.Data;

public class ShopContext : IdentityDbContext
{
    public ShopContext(DbContextOptions<ShopContext> options) : base(options)
    {

    }
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("Products");

        #region Seeding 

        Product[] products = new Product[]
        {
            new() { Id = Guid.NewGuid(), Name = "Laptop", Category = "Electronics", Price = 999.99m, QuantityInStock = 15 },
            new() { Id = Guid.NewGuid(), Name = "Book", Category = "Education", Price = 19.99m, QuantityInStock = 100 },
            new() { Id = Guid.NewGuid(), Name = "Headphones", Category = "Electronics", Price = 49.99m, QuantityInStock = 30 },
            new() { Id = Guid.NewGuid(), Name = "T-shirt", Category = "Apparel", Price = 12.99m, QuantityInStock = 50 },
            new() { Id = Guid.NewGuid(), Name = "Smartphone", Category = "Electronics", Price = 699.99m, QuantityInStock = 25 },
            new() { Id = Guid.NewGuid(), Name = "Coffee Mug", Category = "Kitchen", Price = 9.99m, QuantityInStock = 75 },
            new() { Id = Guid.NewGuid(), Name = "Desk Lamp", Category = "Home Office", Price = 29.99m, QuantityInStock = 20 },
            new() { Id = Guid.NewGuid(), Name = "Running Shoes", Category = "Footwear", Price = 79.99m, QuantityInStock = 40 },
            new() { Id = Guid.NewGuid(), Name = "Backpack", Category = "Accessories", Price = 39.99m, QuantityInStock = 60 },
            new() { Id = Guid.NewGuid(), Name = "External Hard Drive", Category = "Electronics", Price = 129.99m, QuantityInStock = 10 },
            new() { Id = Guid.NewGuid(), Name = "Yoga Mat", Category = "Fitness", Price = 24.99m, QuantityInStock = 35 },
            new() { Id = Guid.NewGuid(), Name = "Pencil Set", Category = "Stationery", Price = 7.99m, QuantityInStock = 80 },
            new() { Id = Guid.NewGuid(), Name = "Gaming Chair", Category = "Furniture", Price = 199.99m, QuantityInStock = 5 },
            new() { Id = Guid.NewGuid(), Name = "Sunglasses", Category = "Accessories", Price = 59.99m, QuantityInStock = 45 },
            new() { Id = Guid.NewGuid(), Name = "Bluetooth Speaker", Category = "Electronics", Price = 89.99m, QuantityInStock = 18 },
            new() { Id = Guid.NewGuid(), Name = "Notebook", Category = "Stationery", Price = 4.99m, QuantityInStock = 120 },
            new() { Id = Guid.NewGuid(), Name = "Gardening Gloves", Category = "Gardening", Price = 14.99m, QuantityInStock = 55 },
            new() { Id = Guid.NewGuid(), Name = "Cooking Utensils Set", Category = "Kitchen", Price = 29.99m, QuantityInStock = 25 },
            new() { Id = Guid.NewGuid(), Name = "Hiking Backpack", Category = "Travel", Price = 69.99m, QuantityInStock = 30 },
            new() { Id = Guid.NewGuid(), Name = "Power Bank", Category = "Electronics", Price = 49.99m, QuantityInStock = 40 }
        };
        modelBuilder.Entity<Product>()
            .HasData(products);

        #endregion
    }
}
