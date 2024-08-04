using Infrastructure.MongoDb;

namespace API.Extensions;

public static class Database
{
    public static void AddDatabase(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddOptions<MongoDbOptions>().BindConfiguration(MongoDbOptions.SectionPath);
        serviceCollection.AddSingleton<MongoDbContext>();
    }
}