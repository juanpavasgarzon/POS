namespace Domain.Discount;

public record DiscountTransaction : Discount
{
    public required decimal MinimumAmount { get; set; }
}