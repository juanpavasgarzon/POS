namespace Domain.Discount;

public record DiscountProduct : Discount
{
    public required string ProductCode { get; set; }
}