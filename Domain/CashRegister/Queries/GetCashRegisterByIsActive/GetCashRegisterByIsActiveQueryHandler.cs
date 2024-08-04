using Pavas.Patterns.Cqrs.Contracts;
using Pavas.Patterns.Result;

namespace Domain.CashRegister.Queries.GetCashRegisterByIsActive;

public class GetCashRegisterByIsActiveQueryHandler(
) : IQueryHandlerAsync<GetCashRegisterByIsActiveQuery, Result<List<CashRegister>>>
{
    public Task<Result<List<CashRegister>>> HandleAsync(
        GetCashRegisterByIsActiveQuery query,
        CancellationToken cancellationToken = new()
    )
    {
        throw new NotImplementedException();
    }
}