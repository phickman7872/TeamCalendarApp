using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCalendarApp.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventTypeId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartsAt = table.Column<DateTime>(nullable: false),
                    EndsAt = table.Column<DateTime>(nullable: true),
                    IsFullDay = table.Column<bool>(nullable: false),
                    ThemeColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    EventTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    ThemeColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    IsManager = table.Column<bool>(nullable: false),
                    IsSiteManager = table.Column<bool>(nullable: false),
                    ReportsTo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "EventTypeId", "DateCreated", "DateUpdated", "Description", "Name", "Prefix", "ThemeColor", "UserCreated", "UserUpdated" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), "1/2 Vacation Day - AM", "1/2 Vacation Day (AM)", "1/2 VAM", "Olive", "system", "system" },
                    { 2, new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), "1/2 Vacation Day - PM", "1/2 Vacation Day (PM)", "1/2 VPM", "Blue", "system", "system" },
                    { 3, new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), "Appointment", "Appointment", "D", "DarkRed", "system", "system" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Company Holiday", "Company Holiday", "C", "DarkSlateGray", null, null },
                    { 5, new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), "Personal Holiday", "Personal Holiday", "P", "Purple", "system", "system" },
                    { 6, new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), "Sick Day", "Sick Day", "S", "CadetBlue", "system", "system" },
                    { 7, new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 716, DateTimeKind.Local), "Work From Home Day", "Work From Home Day", "WFH", "DarkCyan", "system", "system" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateCreated", "DateUpdated", "EmailAddress", "FirstName", "IsManager", "IsSiteManager", "LastName", "ReportsTo", "UserCreated", "UserUpdated", "Username" },
                values: new object[,]
                {
                    { 10, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "CGibson@attentigroup.com", "Carla", false, false, "Gibson", 3, "system", "system", "CGibson" },
                    { 9, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "GUkarande@attentigroup.com", "Girish", false, false, "Ukarande", 2, "system", "system", "GUkarande" },
                    { 8, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "PHickman@attentigroup.com", "Phil", false, false, "Hickman", 3, "system", "system", "PHickman" },
                    { 7, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "MLocklear@attentigroup.com", "Marita", false, false, "Locklear", 2, "system", "system", "MLocklear" },
                    { 6, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "SCupstid@attentigroup.com", "Scott", false, false, "Cupstid", 2, "system", "system", "SCupstid" },
                    { 3, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "JFonnotto@attentigroup.com", "John", true, false, "Fonnotto", 1, "system", "system", "JFonnotto" },
                    { 4, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "JNelson@attentigroup.com", "Jeremy", false, false, "Nelson", 2, "system", "system", "JNelson" },
                    { 11, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "DBoyd@attentigroup.com", "David", false, false, "Boyd", 3, "system", "system", "DBoyd" },
                    { 2, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "DEllingsworth@attentigroup.com", "Don", true, false, "Ellingsworth", 1, "system", "system", "DEllingsworth" },
                    { 1, new DateTime(2018, 11, 28, 11, 15, 22, 714, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "RBuffington@attentigroup.com", "Randy", true, true, "Buffington", 0, "system", "system", "RBuffington" },
                    { 5, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "FBorcan@attentigroup.com", "Fulviu", false, false, "Borcan", 3, "system", "system", "FBorcan" },
                    { 12, new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), new DateTime(2018, 11, 28, 11, 15, 22, 715, DateTimeKind.Local), "SManess@attentigroup.com", "Shannon", false, false, "Maness", 2, "system", "system", "SManess" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
