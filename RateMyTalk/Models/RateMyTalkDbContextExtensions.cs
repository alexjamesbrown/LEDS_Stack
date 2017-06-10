using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RateMyTalk.Models
{
    public static class RateMyTalkDbContextExtensions
    {
        public static void EnsureSeedData(this RateMyTalkDbContext context)
        {
            if (!context.Database.GetPendingMigrations().Any())
            {
                if (!context.Talks.Any())
                {
                    var talk = new Talk()
                    {
                        Title = "LEDS Stack & Developing .net Applications on a Mac",
                        Speaker = "Alex Brown",
                        Description = "We look at the LEDS Stack (Linux, nginx, DotNet, SQL Server) and how to develop ASP.net applications on a Mac, and deploy them to a non-Microsoft cloud. Check out the github repo at https://github.com/alexjamesbrown/LEDS_Stack",
                        Date = new DateTime(2017, 06, 10),
                    };

                    context.Talks.Add(talk);
                    context.SaveChanges();
                }
            }
        }
    }
}