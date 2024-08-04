using Common.Entity;

namespace Domain.Transaction;

public record TransactionTax : BaseEntity
{
    public required string Name { get; set; }
    public required decimal Rate { get; set; }
    public required decimal Amount { get; set; }
}