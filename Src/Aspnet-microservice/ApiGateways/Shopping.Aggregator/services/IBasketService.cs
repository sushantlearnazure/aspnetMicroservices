using Shopping.Aggregator.Models;
using System.Threading.Tasks;

namespace Shopping.Aggregator.services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
