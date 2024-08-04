using API.Constants;

namespace API.Endpoints;

public static class DiscountEndpoints
{
    public static void MapDiscountEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Discount)
            .WithTags(Tags.Discount)
            .WithSummary(Descriptions.Discount);
    }
}