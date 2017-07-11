using Microsoft.AspNetCore.Mvc;

namespace AcronymVote.Controllers
{
    public class ErrorController : Controller
    {
        [Route("error/{code}")]
        public IActionResult Index(string code)
        {
            ViewData["ErrorCode"] = code;
            return View();
        }
    }
}