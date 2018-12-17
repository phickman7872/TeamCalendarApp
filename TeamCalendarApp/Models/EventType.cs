using System.Collections.Generic;

namespace TeamCalendarApp.Models
{
    public class EventType : TrackableObject
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Prefix { get; set; }
        public string ThemeColor { get; set; }

        // An EventType can have many Events.
        public ICollection<Event> Events { get; set; }
    }
}
