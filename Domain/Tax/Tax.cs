namespace Domain.Tax;

public record Tax
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required decimal Percentage { get; set; }
}