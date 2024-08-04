using API.Constants;

namespace API.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Customer)
            .WithTags(Tags.Customer)
            .WithSummary(Descriptions.Customer);
    }
}