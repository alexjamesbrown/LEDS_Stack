using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AcronymVote.Models
{
    public static class AcronymVoteDbContextExtensions
    {
        public static void EnsureSeedData(this AcronymVoteDbContext context)
        {
            if (!context.Database.GetPendingMigrations().Any())
            {
                if (!context.Acronyms.Any())
                {
                    context.AddStackName("LEDS", "<span>L</span>inux, <span>(e)</span>Nginx, <span>D</span>otNet, <span>S</span>QL Server");
                    context.AddStackName("LDOTES", "<span>L</span>inux, <span>Dot</span>Net, <span>(e)</span>Nginx, <span>S</span>QL Server");
                    context.AddStackName("LASER", "<span>L</span>inux, <span>A</span>sp.net Core, <span>S</span>QL Server, <span>E</span>F Core, <span>R</span>ider");
                    context.AddStackName("LESSD", "<span>L</span>inux, <span>(e)</span>Nginx, <span>S</span>QL <span>S</span>erver, <span>D</span>otNet");
                    context.AddStackName("LASS", "<span>L</span>inux, <span>A</span>sp.net Core, <span>S</span>QL <span>S</span>erver");
                    context.AddStackName("LinDEnS", "<span>Lin</span>ux, <span>D</span>otNet, <span>(e)N</span>ginx, <span>S</span>QL Server");
                    context.AddStackName("LASE", "<span>L</span>inux, <span>A</span>sp.Net, <span<S</span>QL Server, <span>(e)</span>Nginx");
                    context.AddStackName("SEAL", "<span>S</span>QL Server, <span>(e)</span>Nginx, <span>A</span>sp.Net, <span>L</span>inux");

                    context.SaveChanges();
                }
            }
        }

        private static void AddStackName(this AcronymVoteDbContext context, string name, string description)
        {
            context.Acronyms.Add(new Acronym
            {
                Value = name,
                Description = description
            });
        }
    }
}