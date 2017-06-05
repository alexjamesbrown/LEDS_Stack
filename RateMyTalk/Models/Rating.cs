using System;
using System.ComponentModel.DataAnnotations;

namespace RateMyTalk.Models
{
    public class Rating
    {
        public int Id { get; set; }
        
        [Range(1, 10, ErrorMessage = "Rating value must be between 1-10")]
        public int Value { get; set; }

        public string Name { get; set; }

        public string Comments { get; set; }

        public virtual Talk Talk {get; set;}
    }
}
