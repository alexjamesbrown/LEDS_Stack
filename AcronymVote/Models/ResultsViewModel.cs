using System.Collections.Generic;

namespace AcronymVote.Models
{
    public class AcronymVoteResultViewModel
    {
        public string Acronym { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
        public int Percentage { get; set; }
    }
}