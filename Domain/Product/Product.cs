namespace Domain.Product;

public record Product
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required decimal Cost { get; set; }
    public required int StockQuantity { get; set; }
    public required ProductCategory ProductCategory { get; set; }
    public required ProductSupplier Supplier { get; set; }
    public required string Barcode { get; set; }
}