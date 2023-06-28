using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;
namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        //bookstore?bookid=100&loggedin=true
        //public IActionResult Index(int? bookid,bool? isloggedin)
        public IActionResult Index(int? bookid, [FromRoute] bool? isloggedin,Book book)
        {
            //Book id should be applied
            if (bookid.HasValue == false)
            {
                //Response.StatusCode = 400;
                // return Content("Book id is not supplied");
                //return new BadRequestResult();
                return BadRequest("Book id is not supplied or empty");
            }
            //Book id can't be less than or equal to 0
            if (bookid <= 0)
            {
                //Response.StatusCode = 400;
                //return Content("Book id can't be null or empty");
                return BadRequest("Book id cannot be less than or equal to 0");
            }
            //Book id should be between 1 to 1000
         
            if (bookid > 1000)
            {
                //Response.StatusCode = 404;
                //return Content("Book id can't be greater then 1000");
                return NotFound("Book id can't be greater then 1000");
            }
            //isloggedin should be true
            if (isloggedin == false)
            {
                return StatusCode(401);
                //Response.StatusCode = 401;
                //return Content("User must be authenticated");
                //return Unauthorized("User must be authenticated");
            }
            return Content($"Book id: {bookid},Book: {book}","text/plain");
        }
    }
}
