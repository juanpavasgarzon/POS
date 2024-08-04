using Pavas.Patterns.Cqrs.Contracts;

namespace Domain.CashRegister.Commands.UpdateCashRegister;

public class UpdateCashRegisterCommandHandler(
) : ICommandHandlerAsync<UpdateCashRegisterCommand>
{
    public Task HandleAsync(
        UpdateCashRegisterCommand command,
        CancellationToken cancellationToken = new()
    )
    {
        throw new NotImplementedException();
    }
}