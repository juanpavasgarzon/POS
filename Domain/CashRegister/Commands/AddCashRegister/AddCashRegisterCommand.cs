namespace Domain.CashRegister.Commands.AddCashRegister;

public record AddCashRegisterCommand
{
    public required string Name { get; init; }
    public required string Location { get; init; }
}

public record AddCashRegisterCommandResponse
{
    public required string Id { get; init; }

    public static AddCashRegisterCommandResponse FromAdd(Guid id) => new()
    {
        Id = id.ToString()
    };
}