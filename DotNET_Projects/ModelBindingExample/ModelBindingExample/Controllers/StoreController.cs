using Microsoft.AspNetCore.Mvc;

namespace ModelBindingExample.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/books")]
        public IActionResult Books()
        {
            //int id = Convert.ToInt32(Request.RouteValues["id"]);
            return Content($"<h1>Book Store </h1>", "text/html");
        }
    }
}
