using Common.Entity;

namespace Domain.Category;

public record Category : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}