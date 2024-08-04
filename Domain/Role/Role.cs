using Common.Entity;

namespace Domain.Role;

public record Role : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;
}