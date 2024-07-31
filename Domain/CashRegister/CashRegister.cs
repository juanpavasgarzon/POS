namespace Domain.CashRegister;

public record CashRegister
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
    public required string CurrentBalance { get; set; }
    public required string Status { get; set; }
}