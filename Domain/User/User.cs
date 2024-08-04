using Common.Entity;

namespace Domain.User;

public record User : BaseEntity
{
    public required string Identifier { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
}