using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.Models;
namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if(!ModelState.IsValid)
            {
                //List<string> errorList = new List<string>();
                //foreach(var value in ModelState.Values)
                //{
                //    foreach(var error in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);
                //    }
                //}
                //string errors = string.Join("\n", errorList);
                string errors = string.Join("\n", ModelState.Values.SelectMany(x => x.Errors).Select(err => err.ErrorMessage).ToList());
                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}
