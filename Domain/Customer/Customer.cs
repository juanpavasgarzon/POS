using Common.Entity;

namespace Domain.Customer;

public record Customer : BaseEntity
{
    public required string Identifier { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
}