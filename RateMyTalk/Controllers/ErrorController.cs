using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using RateMyTalk.Models;

namespace RateMyTalk.Controllers
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