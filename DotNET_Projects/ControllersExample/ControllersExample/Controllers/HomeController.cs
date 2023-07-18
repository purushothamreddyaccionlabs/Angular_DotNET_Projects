using ControllersExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    [Controller]
    public class HomeController:Controller
    {
     
        [Route("/")]
      public ContentResult Index()
        {
            /* return new ContentResult()
             {
                 Content = "Hello from Index",
                 ContentType = "text/plain"
             };*/
            //return Content("Hello from Index", "text/plain");
            return Content("<h1>Wellcome</h1> <h2>Hello from Index</h2>", "text/html");
        }
        [Route("home")]
      public string Home()
        {
            return "Home page";
        }
        [Route("about")]
        public string About()
        {
            return "about page";
        }

        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string ContactUs()
        {
            return "contact us page";
        }
        [Route("Person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {Id = Guid.NewGuid(),
                Firstname="Kiran",Lastname="Kumar",Age=30
            };
            //return new JsonResult(person);
            return Json(person);
        }
        [Route("file-download")]
        public VirtualFileResult Filedownload()
        {
            return new VirtualFileResult("/sample.pdf","application/pdf");
        }
        [Route("file-download2")]
        public PhysicalFileResult Filedownload2()
        {
            return new PhysicalFileResult(@"D:/Typescript/27837791.pdf", "application/pdf");
        }
    }
}
