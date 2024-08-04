using API.Endpoints;

namespace API.Extensions;

public static class Route
{
    public static void MapEndpoints(this WebApplication webApplication)
    {
        webApplication.MapCashRegisterEndpoints();
        webApplication.MapCategoryEndpoints();
        webApplication.MapCustomerEndpoints();
        webApplication.MapDiscountEndpoints();
        webApplication.MapInventoryEndpoints();
        webApplication.MapProductEndpoints();
        webApplication.MapRoleEndpoints();
        webApplication.MapSupplierEndpoints();
        webApplication.MapTaxEndpoints();
        webApplication.MapTransactionEndpoints();
        webApplication.MapUserEndpoints();
    }
}