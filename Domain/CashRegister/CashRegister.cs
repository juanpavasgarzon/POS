using Common.Entity;

namespace Domain.CashRegister;

public record CashRegister : BaseEntity
{
    public required string Code { get; set; }
    public required string Location { get; set; }
    public required string CurrentBalance { get; set; }
    public bool IsActive { get; set; } = true;
}