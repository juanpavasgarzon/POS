using Common.Entity;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.MongoDb;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IOptions<MongoDbOptions> mongoDbOptions)
    {
        var options = mongoDbOptions.Value;
        var settings = MongoClientSettings.FromConnectionString(options.ConnectionString);
        settings.ServerApi = new ServerApi(ServerApiVersion.V1);

        var client = new MongoClient(settings);
        _database = client.GetDatabase(options.DatabaseName);
    }

    public IMongoCollection<T> From<T>() where T : BaseEntity => _database.GetCollection<T>(typeof(T).Name);
}