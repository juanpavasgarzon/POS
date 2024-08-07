using Common.Entity;

namespace Domain.Inventory;

public record InventoryProduct : BaseEntity
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal UnitPrice { get; set; }
}