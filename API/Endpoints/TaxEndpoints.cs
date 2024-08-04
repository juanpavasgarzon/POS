using API.Constants;

namespace API.Endpoints;

public static class TaxEndpoints
{
    public static void MapTaxEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(Resources.Tax)
            .WithTags(Tags.Tax)
            .WithSummary(Descriptions.Tax);
    }
}