namespace Domain.Product;

public record ProductCategory
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}