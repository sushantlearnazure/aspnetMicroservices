using catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            
            var Client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString") );
            var database = Client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
