using EshopApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrders IOrders;
        public OrdersController(IOrders orders)
        {
            this.IOrders = orders;
        }
        [HttpGet]
        [Route("getListOfOrders")]
        public IActionResult getListOfOrders()
        {
            var result = IOrders.ListOfOrders();
            return Ok(result);
        }
    }
}
