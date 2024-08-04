using API.Constants;

namespace API.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Product)
            .WithTags(Tags.Product)
            .WithSummary(Descriptions.Product);
    }
}