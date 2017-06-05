using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RateMyTalk.Models
{
    public class Talk
    {
        public Talk()
        {
            Ratings = new List<Rating>();
        }
        
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Speaker { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual ICollection<Rating> Ratings {get;set;}
    }
}
