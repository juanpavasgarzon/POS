using Pavas.Patterns.Cqrs.Contracts;

namespace Domain.CashRegister.Commands.RemoveCashRegister;

public record RemoveCashRegisterCommandHandler : ICommandHandlerAsync<RemoveCashRegisterCommand>
{
    public Task HandleAsync(
        RemoveCashRegisterCommand command,
        CancellationToken cancellationToken = new()
    )
    {
        throw new NotImplementedException();
    }
}