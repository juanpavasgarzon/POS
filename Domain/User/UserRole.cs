using Common.Entity;

namespace Domain.User;

public record UserRole : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}