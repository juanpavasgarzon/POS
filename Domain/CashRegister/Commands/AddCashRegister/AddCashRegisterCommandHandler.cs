using Pavas.Patterns.Cqrs.Contracts;
using Pavas.Patterns.Result;

namespace Domain.CashRegister.Commands.AddCashRegister;

public class AddCashRegisterCommandHandler(
) : ICommandHandlerAsync<AddCashRegisterCommand, Result<AddCashRegisterCommandResponse>>
{
    public Task<Result<AddCashRegisterCommandResponse>> HandleAsync(
        AddCashRegisterCommand command,
        CancellationToken cancellationToken = new()
    )
    {
        throw new NotImplementedException();
    }
}