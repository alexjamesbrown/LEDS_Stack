using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcronymVote.Models
{
    public class Acronym
    {
        public Acronym()
        {
            Votes = new List<Vote>();
        }
        
        public int Id { get; set; }
        
        [Required]
        public string Value { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Vote> Votes {get;set;}
    }
}