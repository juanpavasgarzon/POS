using Pavas.Patterns.Cqrs.Contracts;
using Pavas.Patterns.Result;

namespace Domain.CashRegister.Queries.GetCashRegister;

public class GetCashRegisterQueryHandler(
) : IQueryHandlerAsync<GetCashRegisterQuery, Result<List<CashRegister>>>
{
    public Task<Result<List<CashRegister>>> HandleAsync(
        GetCashRegisterQuery query,
        CancellationToken cancellationToken = new()
    )
    {
        throw new NotImplementedException();
    }
}