using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AcronymVote.Models;
using Microsoft.EntityFrameworkCore;

namespace AcronymVote.Controllers
{
    public class ResultsController : Controller
    {
        private readonly AcronymVoteDbContext _db;

        public ResultsController(AcronymVoteDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var acronyms = _db.Acronyms
                .Include(x => x.Votes)
                .ToList();

            var totalNumberOfVotes = acronyms.Sum(x => x.Votes.Count);

            var results = new List<AcronymVoteResultViewModel>();

            foreach (var acronym in acronyms)
            {
                var percentage = 0;
                if (totalNumberOfVotes > 0)
                    percentage = Convert.ToInt32(Math.Round((double) acronym.Votes.Count / totalNumberOfVotes * 100, 0));

                var result = new AcronymVoteResultViewModel
                {
                    Acronym = acronym.Value,
                    Description = acronym.Description,
                    Votes = acronym.Votes.Count,
                    Percentage = percentage
                };

                results.Add(result);
            }

            return View(results.OrderByDescending(x => x.Percentage));
        }
    }
}