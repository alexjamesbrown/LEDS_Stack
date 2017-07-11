using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using AcronymVote.Models;

namespace AcronymVote.Controllers
{
    public class HomeController : Controller
    {
        private readonly AcronymVoteDbContext _db;

        public HomeController(AcronymVoteDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var acronyms = _db.Acronyms.ToList();

            return View(acronyms);
        }

        [HttpPost]
        public async Task<IActionResult> Vote(int id)
        {
            //our super secure method of preventing cheating
            var hasVoted = HttpContext.Session.GetString("voted");
            if (hasVoted == "True")
            {
                TempData["voteDeclined"] = true;
                return RedirectToAction("Index", "Results");
            }

            var acronym = _db.Acronyms.SingleOrDefault(x => x.Id == id);
            if (acronym == null)
                return RedirectToAction("Index", "Error", new {code = 404});

            var vote = new Vote
            {
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
            };

            acronym.Votes.Add(vote);
            await _db.SaveChangesAsync();

            HttpContext.Session.SetString("voted", "True");

            TempData["votedAccepted"] = true;
            return RedirectToAction("Index", "Results");
        }
    }
}