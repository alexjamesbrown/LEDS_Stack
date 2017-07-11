using System;
using System.ComponentModel.DataAnnotations;

namespace AcronymVote.Models
{
    public class Vote
    {
        public Vote()
        {
            Date = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public string IPAddress { get; set; }
    
        [Required]
        public int StackNameId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual Acronym Acronym { get; set; }
    }
}