using Microsoft.AspNetCore.Mvc;
using ModelBindingExample.Models;

namespace ModelBindingExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        //Url: /bookstore?bookid=10&isloggedin=true

        //[FromQuery]int? bookid, [FromQuery]bool? isloggedin --- Query
        public IActionResult Index([FromRoute]int? bookid,[FromRoute]bool? isloggedin,Book books)
        {
            //Book id should be supplied
            if (bookid.HasValue == false)
            {
                return BadRequest("Book id is not supplied");
            }

            //Book id can't be empty
            if (bookid == null)
            {
                return BadRequest("Book id can't be null or empty");
            }

            //Book id should be between 1 to 1000
            int bookId = Convert.ToInt16(bookid);
            if (bookId <= 0)
            {
                return BadRequest("Book id can't be less than or equal to zero");
            }
            if (bookId > 1000)
            {
                return NotFound("Book id can't be greater than 1000");
            }

            //isloggedin should be true
            if (Convert.ToBoolean(isloggedin == false))
            {
                //return Unauthorized("User must be authenticated");
                return StatusCode(401);
            }

            return RedirectToAction("Books", "Store", new { }); //301 - Moved permanently
        }
    }
}
