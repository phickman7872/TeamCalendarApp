using Microsoft.EntityFrameworkCore;
using System;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Data
{
    public class TeamCalendarDataContext : DbContext
    {
        public TeamCalendarDataContext(DbContextOptions<TeamCalendarDataContext> options) : base(options)
        { }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Build the associations.


            AddDepartments(modelBuilder);
            AddUsers(modelBuilder);
            AddEventTypes(modelBuilder);
        }

        private void AddDepartments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "Account Reps", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 2, Name = "Finance", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 3, Name = "Hardware Engineering", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 4, Name = "Marketing", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 5, Name = "Monitoring Center", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 6, Name = "Production", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 7, Name = "Sales", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 8, Name = "Software Engineering", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now },
                new Department { DepartmentId = 9, Name = "Supply Chain", UserCreated = "System", DateCreated = DateTime.Now, UserUpdated = "System", DateUpdated = DateTime.Now }
              );
        }

        private void AddUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, DepartmentId = 8, Username = "RBuffington", FirstName = "Randy", LastName = "Buffington", EmailAddress = "RBuffington@attentigroup.com", IsManager = true, IsSiteManager = true, ReportsTo = 0, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 2, DepartmentId = 8, Username = "DEllingsworth", FirstName = "Don", LastName = "Ellingsworth", EmailAddress = "DEllingsworth@attentigroup.com", IsManager = true, IsSiteManager = false, ReportsTo = 1, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 3, DepartmentId = 8, Username = "JFonnotto", FirstName = "John", LastName = "Fonnotto", EmailAddress = "JFonnotto@attentigroup.com", IsManager = true, IsSiteManager = false, ReportsTo = 1, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 4, DepartmentId = 8, Username = "JNelson", FirstName = "Jeremy", LastName = "Nelson", EmailAddress = "JNelson@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 5, DepartmentId = 8, Username = "FBorcan", FirstName = "Fulviu", LastName = "Borcan", EmailAddress = "FBorcan@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 6, DepartmentId = 8, Username = "SCupstid", FirstName = "Scott", LastName = "Cupstid", EmailAddress = "SCupstid@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 7, DepartmentId = 8, Username = "MLocklear", FirstName = "Marita", LastName = "Locklear", EmailAddress = "MLocklear@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 8, DepartmentId = 8, Username = "PHickman", FirstName = "Phil", LastName = "Hickman", EmailAddress = "PHickman@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 9, DepartmentId = 8, Username = "GUkarande", FirstName = "Girish", LastName = "Ukarande", EmailAddress = "GUkarande@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 10, DepartmentId = 8, Username = "CGibson", FirstName = "Carla", LastName = "Gibson", EmailAddress = "CGibson@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 11, DepartmentId = 8, Username = "DBoyd", FirstName = "David", LastName = "Boyd", EmailAddress = "DBoyd@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new User { UserId = 12, DepartmentId = 8, Username = "SManess", FirstName = "Shannon", LastName = "Maness", EmailAddress = "SManess@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2, UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now }
                );
        }

        private void AddEventTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>().HasData(
                new EventType { EventTypeId = 1, Name = "1/2 Vacation Day (AM)", Description = "1/2 Vacation Day - AM", Prefix = "1/2 VAM", ThemeColor = "Olive", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 2, Name = "1/2 Vacation Day (PM)", Description = "1/2 Vacation Day - PM", Prefix = "1/2 VPM", ThemeColor = "Blue", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 3, Name = "Appointment", Description = "Appointment", Prefix = "D", ThemeColor = "DarkRed", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 4, Name = "Company Holiday", Description = "Company Holiday", Prefix = "C", ThemeColor = "DarkSlateGray" },
                new EventType { EventTypeId = 5, Name = "Personal Holiday", Description = "Personal Holiday", Prefix = "P", ThemeColor = "Purple", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 6, Name = "Sick Day", Description = "Sick Day", Prefix = "S", ThemeColor = "CadetBlue", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 7, Name = "Work From Home Day", Description = "Work From Home Day", Prefix = "WFH", ThemeColor = "DarkCyan", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 8, Name = "1/2 Work From Home (AM)", Description = "Work From Home in the AM", Prefix = "WFA", ThemeColor = "DarkCyan", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 9, Name = "1/2 Work From Home (PM)", Description = "Work From Home in the PM", Prefix = "WFP", ThemeColor = "DarkCyan", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now },
                new EventType { EventTypeId = 10, Name = "Vacation Day", Description = "Vacation Day", Prefix = "V", ThemeColor = "Green", UserCreated = "system", DateCreated = DateTime.Now, UserUpdated = "system", DateUpdated = DateTime.Now }
                );
        }
    }
}
