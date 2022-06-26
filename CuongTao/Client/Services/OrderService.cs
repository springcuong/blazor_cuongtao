using System.Net.Http.Json;
using CuongTao.Shared;

namespace CuongTao.Client.Services
{
    public class OrderService : IOrderService
    {
        public readonly HttpClient httpClient;
        public OrderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask PlaceOrder(ShoppingBasket basket)
        {
            await httpClient.PostAsJsonAsync("/orders", basket);
        }
    }
}
