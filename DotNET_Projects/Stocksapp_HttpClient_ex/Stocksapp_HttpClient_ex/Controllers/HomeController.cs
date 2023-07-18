using Microsoft.AspNetCore.Mvc;

namespace Stocksapp_HttpClient_ex.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
