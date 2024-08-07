using Common.Entity;

namespace Domain.Supplier;

public record Supplier : BaseEntity
{
    public required string Identifier { get; set; }
    public required string Name { get; set; }
    public required string ContactName { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Email { get; set; }
    public required string Address { get; set; }
}