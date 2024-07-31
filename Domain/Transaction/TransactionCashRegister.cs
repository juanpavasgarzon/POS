namespace Domain.Transaction;

public record TransactionCashRegister
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
}