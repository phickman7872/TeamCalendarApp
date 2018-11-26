using System;

namespace TeamCalendarApp.Models
{
    public abstract class TrackableObject
    {
        public string UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserUpdated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
