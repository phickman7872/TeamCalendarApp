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
                name: "Departments",
                columns: table => new
                {
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
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
                    DepartmentId = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ThemeColor = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DateCreated", "DateUpdated", "Name", "UserCreated", "UserUpdated" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 12, 17, 11, 40, 36, 116, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 117, DateTimeKind.Local), "Account Reps", "System", "System" },
                    { 2, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Finance", "System", "System" },
                    { 3, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Hardware Engineering", "System", "System" },
                    { 4, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Marketing", "System", "System" },
                    { 5, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Monitoring Center", "System", "System" },
                    { 6, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Production", "System", "System" },
                    { 7, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Sales", "System", "System" },
                    { 8, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Software Engineering", "System", "System" },
                    { 9, new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 118, DateTimeKind.Local), "Supply Chain", "System", "System" }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "EventTypeId", "DateCreated", "DateUpdated", "Description", "Name", "Prefix", "ThemeColor", "UserCreated", "UserUpdated" },
                values: new object[,]
                {
                    { 8, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Work From Home in the AM", "1/2 Work From Home (AM)", "WFA", "DarkCyan", "system", "system" },
                    { 7, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Work From Home Day", "Work From Home Day", "WFH", "DarkCyan", "system", "system" },
                    { 6, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Sick Day", "Sick Day", "S", "CadetBlue", "system", "system" },
                    { 5, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Personal Holiday", "Personal Holiday", "P", "Purple", "system", "system" },
                    { 1, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "1/2 Vacation Day - AM", "1/2 Vacation Day (AM)", "1/2 VAM", "Olive", "system", "system" },
                    { 3, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Appointment", "Appointment", "D", "DarkRed", "system", "system" },
                    { 2, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "1/2 Vacation Day - PM", "1/2 Vacation Day (PM)", "1/2 VPM", "Blue", "system", "system" },
                    { 9, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Work From Home in the PM", "1/2 Work From Home (PM)", "WFP", "DarkCyan", "system", "system" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Company Holiday", "Company Holiday", "C", "DarkSlateGray", null, null },
                    { 10, new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 120, DateTimeKind.Local), "Vacation Day", "Vacation Day", "V", "Green", "system", "system" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateCreated", "DateUpdated", "DepartmentId", "EmailAddress", "FirstName", "IsManager", "IsSiteManager", "LastName", "ReportsTo", "UserCreated", "UserUpdated", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "RBuffington@attentigroup.com", "Randy", true, true, "Buffington", 0, "system", "system", "RBuffington" },
                    { 2, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "DEllingsworth@attentigroup.com", "Don", true, false, "Ellingsworth", 1, "system", "system", "DEllingsworth" },
                    { 3, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "JFonnotto@attentigroup.com", "John", true, false, "Fonnotto", 1, "system", "system", "JFonnotto" },
                    { 4, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "JNelson@attentigroup.com", "Jeremy", false, false, "Nelson", 2, "system", "system", "JNelson" },
                    { 5, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "FBorcan@attentigroup.com", "Fulviu", false, false, "Borcan", 3, "system", "system", "FBorcan" },
                    { 6, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "SCupstid@attentigroup.com", "Scott", false, false, "Cupstid", 2, "system", "system", "SCupstid" },
                    { 7, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "MLocklear@attentigroup.com", "Marita", false, false, "Locklear", 2, "system", "system", "MLocklear" },
                    { 8, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "PHickman@attentigroup.com", "Phil", false, false, "Hickman", 3, "system", "system", "PHickman" },
                    { 9, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "GUkarande@attentigroup.com", "Girish", false, false, "Ukarande", 2, "system", "system", "GUkarande" },
                    { 10, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "CGibson@attentigroup.com", "Carla", false, false, "Gibson", 3, "system", "system", "CGibson" },
                    { 11, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "DBoyd@attentigroup.com", "David", false, false, "Boyd", 3, "system", "system", "DBoyd" },
                    { 12, new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), new DateTime(2018, 12, 17, 11, 40, 36, 119, DateTimeKind.Local), 8, "SManess@attentigroup.com", "Shannon", false, false, "Maness", 2, "system", "system", "SManess" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId",
                table: "Events",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
