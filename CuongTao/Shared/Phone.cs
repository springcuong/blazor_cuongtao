using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace CuongTao.Shared
{
    public class Phone
    {
        public Phone(int id, string name, decimal price,
        PhoneModel phonemodel) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Phonemodel = phonemodel;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public PhoneModel Phonemodel { get; }
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}
