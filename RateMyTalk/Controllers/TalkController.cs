using Microsoft.AspNetCore.Mvc;

namespace RateMyTalk.Controllers
{
    public class TalkController : Controller
    {
        [Route("talk/{id}")]
        public IActionResult Index(int id)
        {
            return View();
        }

        [HttpGet]
        [Route("talk/{id}/rate")]
        public IActionResult Rate(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("talk/{id}/rate")]
        public IActionResult CreateRating()
        {
            return new RedirectToActionResult("Rated", "Talk", null);
        }

        [HttpGet]
        [Route("talk/{id}/rated")]
        public IActionResult Rated(int id)
        {
            return View();
        }
    }
}
