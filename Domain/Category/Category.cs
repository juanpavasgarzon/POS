namespace Domain.Category;

public record Category
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}