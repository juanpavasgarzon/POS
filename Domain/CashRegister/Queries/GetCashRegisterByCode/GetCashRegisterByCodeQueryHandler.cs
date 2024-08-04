using Pavas.Patterns.Cqrs.Contracts;
using Pavas.Patterns.Result;

namespace Domain.CashRegister.Queries.GetCashRegisterByCode;

public class GetCashRegisterByCodeQueryHandler(
) : IQueryHandlerAsync<GetCashRegisterByCodeQuery, Result<List<CashRegister>>>
{
    public Task<Result<List<CashRegister>>> HandleAsync(
        GetCashRegisterByCodeQuery query,
        CancellationToken cancellationToken = new CancellationToken()
    )
    {
        throw new NotImplementedException();
    }
}