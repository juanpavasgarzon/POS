using Common.Entity;

namespace Domain.Transaction;

public record TransactionCustomer : BaseEntity
{
    public required string Identifier { get; set; }
    public required string FullName { get; set; }
}