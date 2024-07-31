namespace Domain.Transaction;

public record Transaction
{
    public required string Id { get; set; }
    public required DateTime TransactionDate { get; set; }
    public required decimal TotalAmount { get; set; }
    public required TransactionPaymentMethod TransactionPaymentMethod { get; set; }
    public required TransactionUser User { get; set; }
    public required TransactionCustomer Customer { get; set; }
    public required TransactionCashRegister CashRegister { get; set; }
    public required List<TransactionItem> TransactionDetails { get; set; }
    public required List<TransactionTax> Taxes { get; set; }
    public required List<TransactionDiscount> Discounts { get; set; }
}