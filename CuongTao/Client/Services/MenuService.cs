using CuongTao.Shared;
using System.Net.Http.Json;

namespace CuongTao.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu()
        {
            var phones = await httpClient
                .GetFromJsonAsync<Phone[]>("/phones");
            return new Menu { Phones = phones!.ToList() };
        }
    }
}
