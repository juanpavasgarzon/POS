using Common.Entity;

namespace Domain.Transaction;

public record TransactionProduct : BaseEntity
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required string CategoryName { get; set; }
    public required string Description { get; set; }
    public required decimal UnitPrice { get; set; }
}