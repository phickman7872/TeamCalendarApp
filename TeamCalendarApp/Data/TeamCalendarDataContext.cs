using Microsoft.EntityFrameworkCore;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Data
{
    public class TeamCalendarDataContext : DbContext
    {
        public TeamCalendarDataContext(DbContextOptions<TeamCalendarDataContext> options) : base(options)
        { }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<StatusItem> StatusItems { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddUsers(modelBuilder);
            AddEventTypes(modelBuilder);
            AddStatusTypes(modelBuilder);
        }

        private void AddUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "RBuffington", FullName = "Randy Buffington", EmailAddress = "RBuffington@attentigroup.com", IsManager = true, IsSiteManager = true, ReportsTo = 0 },
                new User { UserId = 2, Username = "DEllingsworth", FullName = "Don Ellingsworth", EmailAddress = "DEllingsworth@attentigroup.com", IsManager = true, IsSiteManager = false, ReportsTo = 1 },
                new User { UserId = 3, Username = "JFonnotto", FullName = "John Fonnotto", EmailAddress = "JFonnotto@attentigroup.com", IsManager = true, IsSiteManager = false, ReportsTo = 1 },
                new User { UserId = 4, Username = "JNelson", FullName = "Jeremy Nelson", EmailAddress = "JNelson@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 5, Username = "FBorcan", FullName = "Fulviu Borcan", EmailAddress = "FBorcan@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 6, Username = "SCupstid", FullName = "Scott Cupstid", EmailAddress = "SCupstid@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 7, Username = "MLocklear", FullName = "Marita Locklear", EmailAddress = "MLocklear@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 8, Username = "PHickman", FullName = "Phil Hickman", EmailAddress = "PHickman@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 9, Username = "GUkarande", FullName = "Girish Ukarande", EmailAddress = "GUkarande@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 10, Username = "CGibson", FullName = "Carla Gibson", EmailAddress = "CGibson@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 11, Username = "DBoyd", FullName = "David Boyd", EmailAddress = "DBoyd@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 12, Username = "SManess", FullName = "Shannon Maness", EmailAddress = "SManess@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 }
                );
        }

        private void AddEventTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>().HasData(
                new EventType { EventTypeId = 1, Name = "Vacation", Description = "Vacation Day", Prefix = "V", ThemeColor = "Green" },
                new EventType { EventTypeId = 2, Name = "1/2 Vacation Day", Description = "1/2 Vacation Day", Prefix = "1/2 V", ThemeColor = "Olive" },
                new EventType { EventTypeId = 3, Name = "Personal Holiday", Description = "Personal Holiday", Prefix = "P", ThemeColor = "Purple" },
                new EventType { EventTypeId = 4, Name = "Dr.'s Appointment", Description = "Dr.'s Appointment", Prefix = "D", ThemeColor = "Yellow" },
                new EventType { EventTypeId = 5, Name = "Company Holiday", Description = "Company Holiday", Prefix = "C", ThemeColor = "Silver" }
                );
        }

        private void AddStatusTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusType>().HasData(
                new StatusType { StatusTypeId = 1, Title = "Accomplishment", Description = "This is an accomplishment." },
                new StatusType { StatusTypeId = 2, Title = "Impediment", Description = "This is an impediment." },
                new StatusType { StatusTypeId = 3, Title = "Next Two Weeks", Description = "This is an item that I am working on for the next two weeks." },
                new StatusType { StatusTypeId = 4, Title = "Current Projects", Description = "This is a project I'm currently working on." }
                );
        }
    }
}
