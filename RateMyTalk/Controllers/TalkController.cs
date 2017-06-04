using System;
using Microsoft.AspNetCore.Mvc;
using RateMyTalk.Models;

namespace RateMyTalk.Controllers
{
    public class TalkController : Controller
    {
        [Route("talk/{id}")]
        public IActionResult Index(int id)
        {
            var talk = new Talk();
            talk.Id = id;
            talk.Title = "Test Talk";
            talk.Speaker = "John Smith";
            talk.Date = DateTime.Today;

            var viewModel = new TalkDetailsViewModel(talk);

            return View(viewModel);
        }

        [HttpPost]
        [Route("talk/{id}/rate")]
        public IActionResult RateTalk(Rating Rating)
        {
            return new RedirectToActionResult("Rated", "Talk", null);
        }

        [HttpGet]
        [Route("talk/{id}/rated")]
        public IActionResult Rated(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
