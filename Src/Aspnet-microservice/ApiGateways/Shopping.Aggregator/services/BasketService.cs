using Shopping.Aggregator.Extensions;
using Shopping.Aggregator.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Aggregator.services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _HttpClient;
        public BasketService(HttpClient HttpClient)
        {
            _HttpClient= HttpClient;
        }
        public async Task<BasketModel> GetBasket(string userName)
        {
            var response = await _HttpClient.GetAsync($"/api/v1/Basket/{userName}");
            return await response.ReadContentAS<BasketModel>();
        }
    }
}
