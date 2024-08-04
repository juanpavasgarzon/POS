using API.Constants;

namespace API.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.User)
            .WithTags(Tags.User)
            .WithSummary(Descriptions.User);
    }
}