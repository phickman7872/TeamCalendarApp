using System;

namespace TeamCalendarApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int EventTypeId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Desription { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public bool IsFullDay { get; set; }
        public string ThemeColor { get; set; }
    }
}
