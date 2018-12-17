using System.Collections.Generic;

namespace TeamCalendarApp.Models
{
    public class User : TrackableObject
    {
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; }
        public bool IsSiteManager { get; set; }
        public int ReportsTo { get; set; }

        // 1 user can have multiple events.
        public ICollection<Event> Events { get; set; }

        // 1 user can have 1 department.
        public Department Department { get; set; }
    }
}
