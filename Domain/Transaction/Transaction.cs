namespace Domain.Transaction;

public record Transaction
{
    public required string Id { get; set; }
    public required DateTime TransactionDate { get; set; }
    public required decimal TotalAmount { get; set; }
    public required PaymentMethod PaymentMethod { get; set; }
    public required TransactionUser User { get; set; }
    public required TransactionCustomer Customer { get; set; }
    public required TransactionCashRegister CashRegister { get; set; }
    public required string Status { get; set; }
    public required List<TransactionItem> TransactionDetails { get; set; }
}