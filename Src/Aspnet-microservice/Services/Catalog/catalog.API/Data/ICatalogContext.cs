using catalog.API.Entities;
using MongoDB.Driver;

namespace catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
