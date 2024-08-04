using Common.Entity;

namespace Domain.Inventory;

public record Inventory : BaseEntity
{
    public required InventoryProduct Product { get; set; }
    public required decimal Quantity { get; set; }
    public required DateTime LastUpdated { get; set; }
}