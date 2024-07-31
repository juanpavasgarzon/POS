namespace Domain.Transaction;

public record TransactionProduct
{
    public required string Id { get; set; }
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required decimal UnitPrice { get; set; }
}