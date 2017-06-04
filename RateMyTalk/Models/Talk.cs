using System;
using System.Collections.Generic;

namespace RateMyTalk.Models
{
    public class Talk
    {
        public Talk()
        {
            Ratings = new List<Rating>();
        }
        
        public int Id { get; set; }
        
        public string Title { get; set; }

        public string Speaker { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Rating> Ratings {get;set;}
    }
}
