using API.Constants;

namespace API.Endpoints;

public static class CategoryEndpoints
{
    public static void MapCategoryEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Category)
            .WithTags(Tags.Category)
            .WithSummary(Descriptions.Category);

    }
}