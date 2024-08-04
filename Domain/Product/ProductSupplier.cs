using Common.Entity;

namespace Domain.Product;

public record ProductSupplier : BaseEntity
{
    public required string Identifier { get; set; }
    public required string Name { get; set; }
}