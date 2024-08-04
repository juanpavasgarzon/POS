using API.Constants;

namespace API.Endpoints;

public static class TransactionEndpoints
{
    public static void MapTransactionEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Transaction)
            .WithTags(Tags.Transaction)
            .WithSummary(Descriptions.Transaction);
    }
}