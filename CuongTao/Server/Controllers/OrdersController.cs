using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CuongTao.Shared;

namespace CuongTao.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly CuongTaoDbContext db;
        public OrdersController(CuongTaoDbContext db)
        {
            this.db = db;
        }
        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] ShoppingBasket basket)
        {
            Order order = new Order();
            order.Customer = basket.Customer;
            order.Phones = new List<Phone>();
            foreach (int phoneId in basket.Orders)
            {
                var phone = db.Phones.Single(p => p.Id == phoneId);
            }
            db.Orders.Add(order);
            db.SaveChanges();
            return Created("/orders", order.Id);
        }
    }
}
