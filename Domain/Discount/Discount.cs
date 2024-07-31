namespace Domain.Discount;

public abstract record Discount
{
    public required string Id { get; set; }
    public required string Description { get; set; }
    public required decimal Rate { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public bool IsActive { get; set; } = true;
}