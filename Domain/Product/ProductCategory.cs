using Common.Entity;

namespace Domain.Product;

public record ProductCategory : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}