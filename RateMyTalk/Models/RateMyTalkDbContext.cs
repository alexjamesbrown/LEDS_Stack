using System;
using Microsoft.EntityFrameworkCore;

namespace RateMyTalk.Models
{
    public class RateMyTalkDbContext : DbContext
    {
        public RateMyTalkDbContext(DbContextOptions<RateMyTalkDbContext> options)
            : base(options)
        { }

        public DbSet<Talk> Talks { get; set; }
    }
}