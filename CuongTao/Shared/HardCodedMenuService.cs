using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuongTao.Shared
{
    public class HardCodedMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu
            {
                Phones = new List<Phone> {
                    new Phone(1, "Iphone 13 Mini", 20.99M, PhoneModel.Mini),
                    new Phone(2, "Iphone 13 Pro", 22.99M, PhoneModel.Pro),
                    new Phone(3, "Iphone 13 Pro Max ", 25.99M, PhoneModel.ProMax)
                }
            });
    }
}
