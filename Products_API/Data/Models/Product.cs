using System.ComponentModel.DataAnnotations.Schema;

namespace Products_API.Data;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
}
