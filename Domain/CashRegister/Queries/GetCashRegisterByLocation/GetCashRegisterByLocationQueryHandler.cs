using Pavas.Patterns.Cqrs.Contracts;
using Pavas.Patterns.Result;

namespace Domain.CashRegister.Queries.GetCashRegisterByLocation;

public class GetCashRegisterByLocationQueryHandler(
) : IQueryHandlerAsync<GetCashRegisterByLocationQuery, Result<List<CashRegister>>>
{
    public Task<Result<List<CashRegister>>> HandleAsync(
        GetCashRegisterByLocationQuery query,
        CancellationToken cancellationToken = new()
    )
    {
        throw new NotImplementedException();
    }
}