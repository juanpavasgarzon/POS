namespace Infrastructure.MongoDb;

public class MongoDbOptions
{
    public const string SectionPath = "MongoDb";
    public required string ConnectionString { get; set; }
    public required string DatabaseName { get; set; }
}