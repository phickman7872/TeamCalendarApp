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
                name: "StatusItems",
                columns: table => new
                {
                    StatusItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DateEntered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusItems", x => x.StatusItemId);
                });

            migrationBuilder.CreateTable(
                name: "StatusTypes",
                columns: table => new
                {
                    StatusTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTypes", x => x.StatusTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
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
                columns: new[] { "EventTypeId", "Description", "Name", "Prefix", "ThemeColor" },
                values: new object[,]
                {
                    { 1, "Vacation Day", "Vacation", "V", "Green" },
                    { 2, "1/2 Vacation Day", "1/2 Vacation Day", "1/2 V", "Olive" },
                    { 3, "Personal Holiday", "Personal Holiday", "P", "Purple" },
                    { 4, "Dr.'s Appointment", "Dr.'s Appointment", "D", "Yellow" },
                    { 5, "Company Holiday", "Company Holiday", "C", "Silver" }
                });

            migrationBuilder.InsertData(
                table: "StatusTypes",
                columns: new[] { "StatusTypeId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "This is an accomplishment.", "Accomplishments" },
                    { 2, "This is an impediment.", "Impediment" },
                    { 3, "This is an item that I am working on for the next two weeks.", "Next Two Weeks" },
                    { 4, "This is a project I'm currently working on.", "Current Projects" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "EmailAddress", "FirstName", "IsManager", "IsSiteManager", "LastName", "ReportsTo", "Username" },
                values: new object[,]
                {
                    { 10, "CGibson@attentigroup.com", "Carla", false, false, "Gibson", 3, "CGibson" },
                    { 9, "GUkarande@attentigroup.com", "Girish", false, false, "Ukarande", 2, "GUkarande" },
                    { 8, "PHickman@attentigroup.com", "Phil", false, false, "Hickman", 3, "PHickman" },
                    { 7, "MLocklear@attentigroup.com", "Marita", false, false, "Locklear", 2, "MLocklear" },
                    { 6, "SCupstid@attentigroup.com", "Scott", false, false, "Cupstid", 2, "SCupstid" },
                    { 2, "DEllingsworth@attentigroup.com", "Don", true, false, "Ellingsworth", 1, "DEllingsworth" },
                    { 4, "JNelson@attentigroup.com", "Jeremy", false, false, "Nelson", 2, "JNelson" },
                    { 3, "JFonnotto@attentigroup.com", "John", true, false, "Fonnotto", 1, "JFonnotto" },
                    { 11, "DBoyd@attentigroup.com", "David", false, false, "Boyd", 3, "DBoyd" },
                    { 1, "RBuffington@attentigroup.com", "Randy", true, true, "Buffington", 0, "RBuffington" },
                    { 5, "FBorcan@attentigroup.com", "Fulviu", false, false, "Borcan", 3, "FBorcan" },
                    { 12, "SManess@attentigroup.com", "Shannon", false, false, "Maness", 2, "SManess" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "StatusItems");

            migrationBuilder.DropTable(
                name: "StatusTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
