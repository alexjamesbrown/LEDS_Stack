using System;
using System.Collections.Generic;

namespace RateMyTalk.Models
{
    public class TalkDetailsViewModel
    {
        public TalkDetailsViewModel(Talk talk)
        {
            Talk = talk;
        }
        
        public Talk Talk { get; set; }

        public Rating NewRating { get; set; }
    }
}
