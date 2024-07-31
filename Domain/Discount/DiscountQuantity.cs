namespace Domain.Discount;

public record QuantityDiscount : Discount
{
    public required int MinimumQuantity { get; set; }
}