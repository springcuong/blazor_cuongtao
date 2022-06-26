using Microsoft.AspNetCore.Components;
using CuongTao.Shared;

namespace CuongTao.Client.Pages
{
    partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Phone> GetPhoneFromId { get; set; }
        = default!;
        private IEnumerable<(Phone phone, int pos)> Phones { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Phones = Orders.Select((id, pos)
            => (phone: GetPhoneFromId(id), pos: pos));
            TotalPrice = Phones.Select(tuple
            => tuple.phone.Price).Sum();
        }
    }
}
