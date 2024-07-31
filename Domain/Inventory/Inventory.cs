namespace Domain.Inventory;

public record Inventory
{
    public required string Id { get; set; }
    public required Product.Product Product { get; set; }
    public required decimal Quantity { get; set; }
    public required DateTime LastUpdated { get; set; }
}