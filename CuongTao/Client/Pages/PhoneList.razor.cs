using Microsoft.AspNetCore.Components;
using CuongTao.Shared;

namespace CuongTao.Client.Pages
{
    partial class PhoneList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Phone> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Phone> Selected { get; set; }
    }
}
