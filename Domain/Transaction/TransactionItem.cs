using Common.Entity;

namespace Domain.Transaction;

public record TransactionItem : BaseEntity
{
    public required TransactionProduct Product { get; set; }
    public required int Quantity { get; set; }
    public required decimal TotalPrice { get; set; }
    public List<TransactionTax> Taxes { get; set; } = [];
    public List<TransactionDiscount> Discounts { get; set; } = [];
}