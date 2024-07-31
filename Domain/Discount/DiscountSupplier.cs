namespace Domain.Discount;

public record DiscountSupplier : Discount
{
    public required string SupplierIdentifier { get; set; }
}