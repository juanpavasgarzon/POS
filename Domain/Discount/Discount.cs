using Common.Entity;

namespace Domain.Discount;

public record Discount : BaseEntity
{
    public required string Code { get; set; }
    public required string Description { get; set; }
    public required decimal Rate { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public bool IsActive { get; set; } = true;
}