using System;
using Microsoft.AspNetCore.Mvc;
using RateMyTalk.Models;

namespace RateMyTalk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var talk = new Talk();
            talk.Id = 1;
            talk.Title = "Test Talk";
            talk.Description = "This is a test description";
            talk.Speaker = "John Smith";
            talk.Date = DateTime.Today;

            var talks = new []{talk};

            return View(talks);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
