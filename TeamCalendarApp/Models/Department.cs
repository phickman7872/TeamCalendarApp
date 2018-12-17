using System.Collections.Generic;

namespace TeamCalendarApp.Models
{
    public class Department : TrackableObject
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        // A Department can have many Users.
        public ICollection<User> Users { get; set; }
    }
}
