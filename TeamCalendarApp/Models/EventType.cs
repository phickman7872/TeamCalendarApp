using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamCalendarApp.Models
{
    public class EventType : TrackableObject
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Prefix { get; set; }

        [Display(Name = "Theme Color")]
        public string ThemeColor { get; set; }

        // An EventType can have many Events.
        public ICollection<Event> Events { get; set; }
    }
}
