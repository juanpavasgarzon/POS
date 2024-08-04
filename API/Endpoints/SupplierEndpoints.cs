using API.Constants;

namespace API.Endpoints;

public static class SupplierEndpoints
{
    public static void MapSupplierEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Supplier)
            .WithTags(Tags.Supplier)
            .WithSummary(Descriptions.Supplier);
    }
}