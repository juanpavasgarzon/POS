namespace Domain.Discount;

public record DiscountCustomer : Discount
{
    public required string CustomerIdentifier { get; set; }
}