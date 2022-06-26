using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuongTao.Shared
{
    public class Menu
    {
        public List<Phone> Phones { get; set; }
            = new List<Phone>();
        public void Add(Phone phone)
            => Phones.Add(phone);
        public Phone? GetPhone(int id)
            => Phones.SingleOrDefault(phone => phone.Id == id);
    }
}
