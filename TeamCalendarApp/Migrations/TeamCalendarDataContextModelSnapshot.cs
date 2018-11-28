﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamCalendarApp.Data;

namespace TeamCalendarApp.Migrations
{
    [DbContext(typeof(TeamCalendarDataContext))]
    partial class TeamCalendarDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamCalendarApp.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("EndsAt");

                    b.Property<int>("EventTypeId");

                    b.Property<bool>("IsFullDay");

                    b.Property<DateTime>("StartsAt");

                    b.Property<string>("ThemeColor");

                    b.Property<string>("Title");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserUpdated");

                    b.Property<string>("Username");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TeamCalendarApp.Models.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Prefix");

                    b.Property<string>("ThemeColor");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserUpdated");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new { EventTypeId = 1, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), Description = "1/2 Vacation Day - AM", Name = "1/2 Vacation Day (AM)", Prefix = "1/2 VAM", ThemeColor = "Olive", UserCreated = "system", UserUpdated = "system" },
                        new { EventTypeId = 2, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), Description = "1/2 Vacation Day - PM", Name = "1/2 Vacation Day (PM)", Prefix = "1/2 VPM", ThemeColor = "Blue", UserCreated = "system", UserUpdated = "system" },
                        new { EventTypeId = 3, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), Description = "Appointment", Name = "Appointment", Prefix = "D", ThemeColor = "DarkRed", UserCreated = "system", UserUpdated = "system" },
                        new { EventTypeId = 4, DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Company Holiday", Name = "Company Holiday", Prefix = "C", ThemeColor = "DarkSlateGray" },
                        new { EventTypeId = 5, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), Description = "Personal Holiday", Name = "Personal Holiday", Prefix = "P", ThemeColor = "Purple", UserCreated = "system", UserUpdated = "system" },
                        new { EventTypeId = 6, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), Description = "Sick Day", Name = "Sick Day", Prefix = "S", ThemeColor = "CadetBlue", UserCreated = "system", UserUpdated = "system" },
                        new { EventTypeId = 7, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), Description = "Work From Home Day", Name = "Work From Home Day", Prefix = "WFH", ThemeColor = "DarkCyan", UserCreated = "system", UserUpdated = "system" }
                    );
                });

            modelBuilder.Entity("TeamCalendarApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsManager");

                    b.Property<bool>("IsSiteManager");

                    b.Property<string>("LastName");

                    b.Property<int>("ReportsTo");

                    b.Property<string>("UserCreated");

                    b.Property<string>("UserUpdated");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new { UserId = 1, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 714, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "RBuffington@attentigroup.com", FirstName = "Randy", IsManager = true, IsSiteManager = true, LastName = "Buffington", ReportsTo = 0, UserCreated = "system", UserUpdated = "system", Username = "RBuffington" },
                        new { UserId = 2, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "DEllingsworth@attentigroup.com", FirstName = "Don", IsManager = true, IsSiteManager = false, LastName = "Ellingsworth", ReportsTo = 1, UserCreated = "system", UserUpdated = "system", Username = "DEllingsworth" },
                        new { UserId = 3, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "JFonnotto@attentigroup.com", FirstName = "John", IsManager = true, IsSiteManager = false, LastName = "Fonnotto", ReportsTo = 1, UserCreated = "system", UserUpdated = "system", Username = "JFonnotto" },
                        new { UserId = 4, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "JNelson@attentigroup.com", FirstName = "Jeremy", IsManager = false, IsSiteManager = false, LastName = "Nelson", ReportsTo = 2, UserCreated = "system", UserUpdated = "system", Username = "JNelson" },
                        new { UserId = 5, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "FBorcan@attentigroup.com", FirstName = "Fulviu", IsManager = false, IsSiteManager = false, LastName = "Borcan", ReportsTo = 3, UserCreated = "system", UserUpdated = "system", Username = "FBorcan" },
                        new { UserId = 6, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "SCupstid@attentigroup.com", FirstName = "Scott", IsManager = false, IsSiteManager = false, LastName = "Cupstid", ReportsTo = 2, UserCreated = "system", UserUpdated = "system", Username = "SCupstid" },
                        new { UserId = 7, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "MLocklear@attentigroup.com", FirstName = "Marita", IsManager = false, IsSiteManager = false, LastName = "Locklear", ReportsTo = 2, UserCreated = "system", UserUpdated = "system", Username = "MLocklear" },
                        new { UserId = 8, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "PHickman@attentigroup.com", FirstName = "Phil", IsManager = false, IsSiteManager = false, LastName = "Hickman", ReportsTo = 3, UserCreated = "system", UserUpdated = "system", Username = "PHickman" },
                        new { UserId = 9, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "GUkarande@attentigroup.com", FirstName = "Girish", IsManager = false, IsSiteManager = false, LastName = "Ukarande", ReportsTo = 2, UserCreated = "system", UserUpdated = "system", Username = "GUkarande" },
                        new { UserId = 10, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "CGibson@attentigroup.com", FirstName = "Carla", IsManager = false, IsSiteManager = false, LastName = "Gibson", ReportsTo = 3, UserCreated = "system", UserUpdated = "system", Username = "CGibson" },
                        new { UserId = 11, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "DBoyd@attentigroup.com", FirstName = "David", IsManager = false, IsSiteManager = false, LastName = "Boyd", ReportsTo = 3, UserCreated = "system", UserUpdated = "system", Username = "DBoyd" },
                        new { UserId = 12, DateCreated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), DateUpdated = new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), EmailAddress = "SManess@attentigroup.com", FirstName = "Shannon", IsManager = false, IsSiteManager = false, LastName = "Maness", ReportsTo = 2, UserCreated = "system", UserUpdated = "system", Username = "SManess" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
