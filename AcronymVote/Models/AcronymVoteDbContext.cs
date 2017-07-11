using System;
using Microsoft.EntityFrameworkCore;

namespace AcronymVote.Models
{
    public class AcronymVoteDbContext : DbContext
    {
        public AcronymVoteDbContext(DbContextOptions<AcronymVoteDbContext> options)
            : base(options)
        { }

        public DbSet<Acronym> Acronyms { get; set; }
    }
}