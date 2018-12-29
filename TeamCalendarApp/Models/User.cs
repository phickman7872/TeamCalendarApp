using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamCalendarApp.Models
{
    public class User : TrackableObject
    {
        public int UserId { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public string Username { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Is Manager")]
        public bool IsManager { get; set; }

        [Display(Name = "Is Site Manager")]
        public bool IsSiteManager { get; set; }

        [Display(Name = "Reports To")]
        public int ReportsTo { get; set; }

        public string FullName => FirstName + " " + LastName;

        // 1 user can have multiple events.
        public ICollection<Event> Events { get; set; }

        // 1 user can have 1 department.
        public Department Department { get; set; }
    }
}
