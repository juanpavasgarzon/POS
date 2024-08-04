using API.Constants;

namespace API.Endpoints;

public static class RoleEndpoints
{
    public static void MapRoleEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Role)
            .WithTags(Tags.Role)
            .WithSummary(Descriptions.Role);
    }
}