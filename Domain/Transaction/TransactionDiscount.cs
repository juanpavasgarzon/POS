using Common.Entity;

namespace Domain.Transaction;

public record TransactionDiscount : BaseEntity
{
    public required string Code { get; set; }
    public required string Description { get; set; }
    public required decimal Rate { get; set; }
    public required decimal Amount { get; set; }
}