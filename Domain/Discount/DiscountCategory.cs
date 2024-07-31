namespace Domain.Discount;

public record DiscountCategory : Discount
{
    public required string CategoryName { get; set; }
}