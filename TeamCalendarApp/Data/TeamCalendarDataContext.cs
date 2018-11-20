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
                new User { UserId = 1, Username = "RBuffington", FirstName = "Randy", LastName = "Buffington", EmailAddress = "RBuffington@attentigroup.com", IsManager = true, IsSiteManager = true, ReportsTo = 0 },
                new User { UserId = 2, Username = "DEllingsworth", FirstName = "Don", LastName = "Ellingsworth", EmailAddress = "DEllingsworth@attentigroup.com", IsManager = true, IsSiteManager = false, ReportsTo = 1 },
                new User { UserId = 3, Username = "JFonnotto", FirstName = "John", LastName = "Fonnotto", EmailAddress = "JFonnotto@attentigroup.com", IsManager = true, IsSiteManager = false, ReportsTo = 1 },
                new User { UserId = 4, Username = "JNelson", FirstName = "Jeremy", LastName = "Nelson", EmailAddress = "JNelson@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 5, Username = "FBorcan", FirstName = "Fulviu", LastName = "Borcan", EmailAddress = "FBorcan@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 6, Username = "SCupstid", FirstName = "Scott", LastName = "Cupstid", EmailAddress = "SCupstid@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 7, Username = "MLocklear", FirstName = "Marita", LastName = "Locklear", EmailAddress = "MLocklear@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 8, Username = "PHickman", FirstName = "Phil", LastName = "Hickman", EmailAddress = "PHickman@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 9, Username = "GUkarande", FirstName = "Girish", LastName = "Ukarande", EmailAddress = "GUkarande@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 },
                new User { UserId = 10, Username = "CGibson", FirstName = "Carla", LastName = "Gibson", EmailAddress = "CGibson@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 11, Username = "DBoyd", FirstName = "David", LastName = "Boyd", EmailAddress = "DBoyd@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 3 },
                new User { UserId = 12, Username = "SManess", FirstName = "Shannon", LastName = "Maness", EmailAddress = "SManess@attentigroup.com", IsManager = false, IsSiteManager = false, ReportsTo = 2 }
                );
        }

        private void AddEventTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>().HasData(
                new EventType { EventTypeId = 1, Name = "Vacation", Description = "Vacation Day", Prefix = "V", ThemeColor = "Green" },
                new EventType { EventTypeId = 2, Name = "1/2 Vacation Day (AM)", Description = "1/2 Vacation Day - AM", Prefix = "1/2 VAM", ThemeColor = "Olive" },
                new EventType { EventTypeId = 3, Name = "Personal Holiday", Description = "Personal Holiday", Prefix = "P", ThemeColor = "Purple" },
                new EventType { EventTypeId = 4, Name = "Appointment", Description = "Appointment", Prefix = "D", ThemeColor = "DarkRed" },
                new EventType { EventTypeId = 5, Name = "Company Holiday", Description = "Company Holiday", Prefix = "C", ThemeColor = "DarkSlateGray" },
                new EventType { EventTypeId = 6, Name = "1/2 Vacation Day (PM)", Description = "1/2 Vacation Day - PM", Prefix = "1/2 VPM", ThemeColor = "Olive" },
                new EventType { EventTypeId = 7, Name = "Sick Day", Description = "Sick Day", Prefix = "S", ThemeColor = "DarkSlateGray" }
                );
        }

        private void AddStatusTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusType>().HasData(
                new StatusType { StatusTypeId = 1, Title = "Accomplishments", Description = "This is an accomplishment." },
                new StatusType { StatusTypeId = 2, Title = "Impediment", Description = "This is an impediment." },
                new StatusType { StatusTypeId = 3, Title = "Next Two Weeks", Description = "This is an item that I am working on for the next two weeks." },
                new StatusType { StatusTypeId = 4, Title = "Current Projects", Description = "This is a project I'm currently working on." }
                );
        }
    }
}
