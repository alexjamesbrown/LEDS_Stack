using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RateMyTalk.Models;

namespace RateMyTalk.Controllers
{
    public class TalkController : Controller
    {
        private readonly RateMyTalkDbContext _db;

        public TalkController(RateMyTalkDbContext db)
        {
            _db = db;
        }

        [Route("talk/{id}")]
        public IActionResult Index(int id)
        {
            var talk = _db.Talks
                .Include(x => x.Ratings)
                .SingleOrDefault(x => x.Id == id);

            //todo: if talk is null, return 404;

            var viewModel = new TalkDetailsViewModel(talk);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("talk/{id}/rate")]
        public IActionResult RateTalk(int talkId, Rating newRating)
        {
            var talk = _db.Talks.SingleOrDefault(x => x.Id == talkId);
            //todo: if talk is null

            if (!ModelState.IsValid)
            {
                var viewModel = new TalkDetailsViewModel(talk);
                viewModel.Talk = talk;
                return View("Index", viewModel);
            }

            talk.Ratings.Add(newRating);
            _db.SaveChanges();

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
