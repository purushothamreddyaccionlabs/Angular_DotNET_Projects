using HSPAWebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace HSPAWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private readonly DataContext db;
        public CityController(DataContext dc)
        {
            db = dc;
        }


        [HttpGet]
        public IActionResult Getstring()
        {
            var cities = db.Cities.ToList();
            return Ok(cities);
        }
    }
}
