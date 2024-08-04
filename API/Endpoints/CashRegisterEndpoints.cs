using API.Constants;
using Domain.CashRegister.Commands.AddCashRegister;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Pavas.Patterns.Cqrs.Contracts;
using Pavas.Patterns.Result;

namespace API.Endpoints;

public static class CashRegisterEndpoints
{
    public static void MapCashRegisterEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.CashRegister)
            .WithTags(Tags.CashRegister)
            .WithSummary(Descriptions.CashRegister);

        group.MapGet(string.Empty, HandleFindAllAsync);
        group.MapPost(string.Empty, HandleAddAsync);
    }

    private static async Task<Results<Ok<string>, BadRequest<ProblemDetails>>> HandleFindAllAsync()
    {
        return TypedResults.Ok("Example 1");
    }
    
    private static async Task<Results<Created<string>, BadRequest<ProblemDetails>>> HandleAddAsync(
        ICommandDispatcher commandDispatcher
    )
    {
        var command = new AddCashRegisterCommand
        {
            Name = string.Empty,
            Location = string.Empty,
        };

        var result = await commandDispatcher
            .DispatchAsync<AddCashRegisterCommand, Result<AddCashRegisterCommandResponse>>(command);

        return TypedResults.Created(string.Empty, result.Value!.Id);
    }
}