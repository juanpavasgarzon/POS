using API.Constants;

namespace API.Endpoints;

public static class InventoryEndpoints
{
    public static void MapInventoryEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Inventory)
            .WithTags(Tags.Inventory)
            .WithSummary(Descriptions.Inventory);
    }
}