using EcommerceApp.Models;
using EcommerceApp.RepositoryLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        //private readonly ApplicationDbContext _db;
        //public GroceryController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}

       // [HttpGet]
    //    public async Task<IEnumerable<Grocery>> Get()
    //        => await _db.groceries.ToListAsync();
    }
}
