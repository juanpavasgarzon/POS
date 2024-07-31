namespace Domain.Transaction;

public record TransactionCustomer
{
    public required string Id { get; set; }
    public required string Identifier { get; set; }
    public required string FullName { get; set; }
}