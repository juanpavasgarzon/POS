using Common.Entity;

namespace Domain.Transaction;

public record TransactionCashRegister : BaseEntity
{
    public required string Code { get; set; }
    public required string Location { get; set; }
}