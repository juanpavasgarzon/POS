namespace Domain.User;

public record User
{
    public required string Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Role { get; set; }
    public bool Status { get; set; } = true;
}