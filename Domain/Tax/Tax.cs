using Common.Entity;

namespace Domain.Tax;

public record Tax : BaseEntity
{
    public required string Name { get; set; }
    public required decimal Rate { get; set; }
}