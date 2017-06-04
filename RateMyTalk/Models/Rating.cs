using System;
namespace RateMyTalk.Models
{
    public class Rating
    {
        public int Id { get; set; }
        
        public int Value { get; set; }

        public string Comments { get; set; }

        public virtual Talk Talk {get; set;}
    }
}
