namespace Domain.User;

public record UserRole
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}