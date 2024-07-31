namespace Domain.Inventory;

public record InventoryProduct
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required decimal UnitPrice { get; set; }
}