namespace Domain.Transaction;

public record TransactionTax
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required decimal Rate { get; set; }
    public required decimal Amount { get; set; }
}