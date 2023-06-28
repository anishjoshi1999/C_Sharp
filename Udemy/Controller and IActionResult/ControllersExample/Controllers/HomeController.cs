using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

namespace ControllersExample.Controllers
{
    // public class HomeController
    [Controller]
   public class HomeController :Microsoft.AspNetCore.Mvc.Controller 
    {
        //Attribute routing
        [Route("home")]
        [Route("/")]
        //returns a ContentResult type
        public ContentResult Index()
        {
            //return new ContentResult()
            //{
            //    Content = "Hello from Index",
            //    ContentType = "text/html"
            //};
            //return Content("Hello from Index","text/plain");
            return Content("<h1>Welcome</h1><h2>Hello From Index</h2>","text/html");
        }
        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person() { 
            Id = Guid.NewGuid(),
            FirstName = "Anish",
            LastName = "Joshi",
            Age = 25
            };
            //return new JsonResult(person);
            return Json(person);
            //return "{\"key\":\"value\"}";
        }
        [Route("contact")]
        public string Contact()
        {
            return "Hello From Contact";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("file-download")]
        public VirtualFileResult FileDownload()
        {
            //default location is wwwroot
            return new VirtualFileResult("/sample.pdf","application/pdf");
        }

        [Route("file-download2")]
        public PhysicalFileResult FileDownload2()
        {
            //default location is wwwroot
            return new PhysicalFileResult(@"c:\Users\anish.joshi\Desktop\Learning\Udemy\ControllersExample\wwwroot\sample.pdf", "application/pdf");
        }
        [Route("file-download3")]
        public FileContentResult FileDownload3()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"c:\Users\anish.joshi\Desktop\Learning\Udemy\ControllersExample\wwwroot\sample.pdf");
            //default location is wwwroot
            return new FileContentResult(bytes,"application/pdf");
        }
        public IActionResult FileDownload4()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"c:\Users\anish.joshi\Desktop\Learning\Udemy\ControllersExample\wwwroot\sample.pdf");
            //default location is wwwroot
            return new FileContentResult(bytes, "application/pdf");
        }
    }
}
