namespace Domain.Product;

public record ProductSupplier
{
    public required string Id { get; set; }
    public required string Identifier { get; set; }
    public required string Name { get; set; }
}