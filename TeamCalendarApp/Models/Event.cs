using System;

namespace TeamCalendarApp.Models
{
    public class Event : TrackableObject
    {
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public bool IsFullDay { get; set; }
        public string ThemeColor { get; set; }

        // An Event can have only 1 EventType.
        public EventType EventType { get; set; }

        // An Event can have only 1 User.
        public User User { get; set; }
    }
}
