using Microsoft.AspNetCore.Components;
using CuongTao.Shared;

namespace CuongTao.Client.Pages
{
    partial class PhoneItem
    {
        [Parameter]
        public Phone Phone { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Phone> Selected { get; set; }
        private string PhoneModelImage(PhoneModel phonemodel)
        => $"images/{phonemodel.ToString().ToLower()}.png";
    }
}
