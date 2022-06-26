using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CuongTao.Shared;

namespace CuongTao.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly CuongTaoDbContext db;
        public PhonesController(CuongTaoDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/phones")]
        public IQueryable<Phone> GetPhones()
        => this.db.Phones;

        [HttpPost("/phones")]
        public IActionResult InsertPhone([FromBody] Phone phone)
        {
            db.Phones.Add(phone);
            db.SaveChanges();
            return Created($"phones/{phone.Id}", phone);
        }
    }
}
