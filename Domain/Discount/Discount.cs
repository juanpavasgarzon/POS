namespace Domain.Discount;

public record Discount
{
    public required string Id { get; set; }
    public required string Description { get; set; }
    public required decimal Percentage { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public bool Status { get; set; } = true;
}