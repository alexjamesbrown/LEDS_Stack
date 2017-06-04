using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using RateMyTalk.Models;

namespace RateMyTalk.Controllers
{
    public class HomeController : Controller
    {
        private readonly RateMyTalkDbContext _db;

        public HomeController(RateMyTalkDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var talks = _db.Talks.ToList();

            return View(talks);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
