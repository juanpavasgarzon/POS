using Common.Entity;

namespace Domain.Transaction;

public record TransactionUser : BaseEntity
{
    public required string Identifier { get; set; }
    public required string Username { get; set; }
    public required string FullName { get; set; }
    public required string Role { get; set; }
}