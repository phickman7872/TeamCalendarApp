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
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
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
                    EventTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
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
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
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
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false),
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
                    { 1, new DateTime(2019, 1, 4, 16, 0, 58, 711, DateTimeKind.Local).AddTicks(406), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(3938), "Account Management", "System", "System" },
                    { 16, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4441), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4444), "Logistics", "System", "System" },
                    { 15, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4438), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4438), "Quality Assurance", "System", "System" },
                    { 14, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4433), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4436), "Human Resources", "System", "System" },
                    { 12, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4424), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4427), "IT", "System", "System" },
                    { 11, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4421), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4424), "Test Engineering", "System", "System" },
                    { 10, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4387), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4387), "General and Administration", "System", "System" },
                    { 9, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4381), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4384), "Supply Chain", "System", "System" },
                    { 13, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4430), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4430), "Research and Development", "System", "System" },
                    { 7, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4376), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4376), "Sales", "System", "System" },
                    { 6, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4370), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4373), "Production", "System", "System" },
                    { 5, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4367), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4367), "Monitoring Center", "System", "System" },
                    { 4, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4364), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4364), "Marketing", "System", "System" },
                    { 3, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4359), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4362), "Hardware Engineering", "System", "System" },
                    { 2, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4342), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4353), "Finance", "System", "System" },
                    { 8, new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4379), new DateTime(2019, 1, 4, 16, 0, 58, 712, DateTimeKind.Local).AddTicks(4381), "Software Engineering", "System", "System" }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "EventTypeId", "DateCreated", "DateUpdated", "Description", "Name", "Prefix", "ThemeColor", "UserCreated", "UserUpdated" },
                values: new object[,]
                {
                    { 8, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7167), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7170), "Work From Home in the AM", "1/2 Work From Home (AM)", "WFA", "DarkCyan", "system", "system" },
                    { 7, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7164), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7164), "Work From Home Day", "Work From Home Day", "WFH", "DarkCyan", "system", "system" },
                    { 6, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7159), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7162), "Sick Day", "Sick Day", "S", "CadetBlue", "system", "system" },
                    { 5, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7156), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7156), "Personal Holiday", "Personal Holiday", "P", "Purple", "system", "system" },
                    { 2, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7145), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7147), "1/2 Vacation Day - PM", "1/2 Vacation Day (PM)", "1/2 VPM", "Blue", "system", "system" },
                    { 3, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7150), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7153), "Appointment", "Appointment", "D", "DarkRed", "system", "system" },
                    { 1, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7116), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7125), "1/2 Vacation Day - AM", "1/2 Vacation Day (AM)", "1/2 VAM", "Olive", "system", "system" },
                    { 9, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7170), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7173), "Work From Home in the PM", "1/2 Work From Home (PM)", "WFP", "DarkCyan", "system", "system" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Company Holiday", "Company Holiday", "C", "DarkSlateGray", null, null },
                    { 10, new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7176), new DateTime(2019, 1, 4, 16, 0, 58, 727, DateTimeKind.Local).AddTicks(7179), "Vacation Day", "Vacation Day", "V", "Green", "system", "system" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateCreated", "DateUpdated", "DepartmentId", "EmailAddress", "FirstName", "IsManager", "IsSiteManager", "LastName", "ReportsTo", "UserCreated", "UserUpdated", "Username" },
                values: new object[,]
                {
                    { 11, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7189), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7192), 1, "RSemago@attentigroup.com", "Rachel", false, false, "Semago", 1, "System", "System", "RSemago" },
                    { 83, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7522), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7525), 7, "WBahlau@attentigroup.com", "William", false, false, "Bahlau", 58, "System", "System", "WBahlau" },
                    { 84, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7528), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7528), 7, "EVickerman@attentigroup.com", "Erica", false, false, "Vickerman", 59, "System", "System", "EVickerman" },
                    { 85, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7531), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7534), 7, "JSmith@attentigroup.com", "Joshua", false, false, "Smith", 59, "System", "System", "JSmith" },
                    { 86, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7536), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7536), 7, "KStephenson@attentigroup.com", "Kristin", false, false, "Stephenson", 59, "System", "System", "KStephenson" },
                    { 87, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7539), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7542), 7, "LAdent@attentigroup.com", "Lisa", false, false, "Adent", 59, "System", "System", "LAdent" },
                    { 88, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7545), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7545), 7, "SStennes@attentigroup.com", "Stefany", false, false, "Stennes", 59, "System", "System", "SStennes" },
                    { 120, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7679), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7682), 7, "AMenichino@attentigroup.com", "Andrew", false, false, "Menichino", 10, "System", "System", "AMenichino" },
                    { 82, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7519), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7519), 7, "THappel@attentigroup.com", "Thomas", false, false, "Happel", 58, "System", "System", "THappel" },
                    { 121, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7684), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7684), 7, "ALedbetter@attentigroup.com", "Autumn", false, false, "Ledbetter", 10, "System", "System", "ALedbetter" },
                    { 123, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7693), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7693), 7, "JMcClain@attentigroup.com", "John", false, false, "McClain", 10, "System", "System", "JMcClain" },
                    { 124, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7696), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7699), 7, "JShephard@attentigroup.com", "Joshua", false, false, "Shephard", 10, "System", "System", "JShephard" },
                    { 125, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7701), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7701), 7, "NLanier@attentigroup.com", "Nichole", false, false, "Lanier", 10, "System", "System", "NLanier" },
                    { 126, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7704), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7707), 7, "RWittenberg@attentigroup.com", "Ronald", false, false, "Wittenberg", 10, "System", "System", "RWittenberg" },
                    { 135, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7741), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7744), 8, "GUkarande@attentigroup.com", "Girish", false, false, "Ukarande", 127, "System", "System", "GUkarande" },
                    { 136, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7747), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7750), 8, "JNelson@attentigroup.com", "Jeremy", false, false, "Nelson", 127, "System", "System", "JNelson" },
                    { 137, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7750), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7753), 8, "SCupstid@attentigroup.com", "Scott", false, false, "Cupstid", 127, "System", "System", "SCupstid" },
                    { 122, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7687), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7690), 7, "BCarrigan@attentigroup.com", "Beau", false, false, "Carrigan", 10, "System", "System", "BCarrigan" },
                    { 138, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7755), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7755), 8, "MLocklear@attentigroup.com", "Marita", false, false, "Locklear", 127, "System", "System", "MLocklear" },
                    { 81, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7514), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7517), 7, "SCalcagni@attentigroup.com", "Scott", false, false, "Calcagni", 58, "System", "System", "SCalcagni" },
                    { 79, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7505), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7508), 7, "DSerafino@attentigroup.com", "David", false, false, "Serafino", 58, "System", "System", "DSerafino" },
                    { 101, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7599), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7602), 6, "LMesker@attentigroup.com", "Lester", false, false, "Mesker", 7, "System", "System", "LMesker" },
                    { 102, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7602), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7605), 6, "MNoe@attentigroup.com", "Matthew", false, false, "Noe", 7, "System", "System", "MNoe" },
                    { 103, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7608), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7610), 6, "MDemos@attentigroup.com", "Mike", false, false, "Demos", 7, "System", "System", "MDemos" },
                    { 104, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7610), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7613), 6, "MSayre@attentigroup.com", "Michael", false, false, "Sayre", 7, "System", "System", "MSayre" },
                    { 105, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7616), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7619), 6, "MWestmoreland@attentigroup.com", "Michael", false, false, "Westmoreland", 7, "System", "System", "MWestmoreland" },
                    { 106, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7619), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7622), 6, "OGonzalez@attentigroup.com", "Oscar", false, false, "Gonzalez", 7, "System", "System", "OGonzalez" },
                    { 107, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7625), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7627), 6, "RLangner@attentigroup.com", "Richard", false, false, "Langner", 7, "System", "System", "RLangner" },
                    { 80, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7511), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7511), 7, "DTalarico@attentigroup.com", "David", false, false, "Talarico", 58, "System", "System", "DTalarico" },
                    { 108, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7627), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7630), 6, "RBewyer@attentigroup.com", "Ronnal", false, false, "Bewyer", 7, "System", "System", "RBewyer" },
                    { 110, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7636), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7639), 6, "SMyers@attentigroup.com", "Scott", false, false, "Myers", 7, "System", "System", "SMyers" },
                    { 111, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7642), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7645), 6, "SHeppding@attentigroup.com", "Sheena", false, false, "Heppding", 7, "System", "System", "SHeppding" },
                    { 112, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7645), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7647), 6, "TWilliams@attentigroup.com", "Tom", false, false, "Williams", 7, "System", "System", "TWilliams" },
                    { 113, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7650), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7653), 6, "YLopez-Maldonado@attentigroup.com", "Yolanda", false, false, "Lopez-Maldonado", 7, "System", "System", "YLopez-Maldonado" },
                    { 5, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7164), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7167), 7, "ECallejas@attentigroup.com", "Edward", true, false, "Callejas", 1, "System", "System", "ECallejas" },
                    { 10, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7187), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7187), 7, "PDrews@attentigroup.com", "Paul", true, false, "Drews", 1, "System", "System", "PDrews" },
                    { 78, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7502), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7502), 7, "DDethlefsen@attentigroup.com", "David", false, false, "Dethlefsen", 58, "System", "System", "DDethlefsen" },
                    { 109, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7633), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7636), 6, "SSalazar@attentigroup.com", "Sandra", false, false, "Salazar", 7, "System", "System", "SSalazar" },
                    { 139, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7758), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7761), 8, "SManess@attentigroup.com", "Shannon", false, false, "Maness", 127, "System", "System", "SManess" },
                    { 143, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7798), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7798), 8, "CGibson@attentigroup.com", "Carla", false, false, "Gibson", 129, "System", "System", "CGibson" },
                    { 144, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7801), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7804), 8, "DGerard@attentigroup.com", "Don", false, false, "Gerard", 129, "System", "System", "DGerard" },
                    { 119, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7676), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7676), 12, "NKent@attentigroup.com", "Nathan", false, false, "Kent", 115, "System", "System", "NKent" },
                    { 12, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7195), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7195), 13, "RBuffington@attentigroup.com", "Randy", true, false, "Buffington", 1, "System", "System", "RBuffington" },
                    { 127, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7710), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7710), 13, "DEllingsworth@attentigroup.com", "Don", true, false, "Ellingsworth", 12, "System", "System", "DEllingsworth" },
                    { 128, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7713), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7716), 13, "HMitchell@attentigroup.com", "Henry", false, false, "Mitchell", 12, "System", "System", "HMitchell" },
                    { 129, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7716), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7718), 13, "JHarper@attentigroup.com", "James", true, false, "Harper", 12, "System", "System", "JHarper" },
                    { 130, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7721), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7724), 13, "JFonnotto@attentigroup.com", "John", true, false, "Fonnotto", 12, "System", "System", "JFonnotto" },
                    { 131, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7724), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7727), 13, "JMizio@attentigroup.com", "John", true, false, "Mizio", 12, "System", "System", "JMizio" },
                    { 118, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7670), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7673), 12, "MDeSamJorge@attentigroup.com", "Michael", false, false, "DeSamJorge", 115, "System", "System", "MDeSamJorge" },
                    { 132, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7730), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7730), 13, "MPatel@attentigroup.com", "Mahendra", true, false, "Patel", 12, "System", "System", "MPatel" },
                    { 134, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7738), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7738), 13, "UOkoye@attentigroup.com", "Uche", false, false, "Okoye", 12, "System", "System", "UOkoye" },
                    { 13, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7198), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7201), 14, "SWiebe@attentigroup.com", "Sandra", true, false, "Wiebe", 1, "System", "System", "SWiebe" },
                    { 148, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7818), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7821), 15, "EYoung@attentigroup.com", "Emily", false, false, "Young", 131, "System", "System", "EYoung" },
                    { 149, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7824), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7824), 15, "MMelichar@attentigroup.com", "Mark", false, false, "Melichar", 131, "System", "System", "MMelichar" },
                    { 150, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7827), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7829), 15, "MGendrau@attentigroup.com", "Mary", false, false, "Gendrau", 131, "System", "System", "MGendrau" },
                    { 151, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7829), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7832), 15, "PSablan@attentigroup.com", "Pam", false, false, "Sablan", 131, "System", "System", "PSablan" },
                    { 152, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7835), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7838), 15, "RPhillip@attentigroup.com", "Robert", false, false, "Phillip", 131, "System", "System", "RPhillip" },
                    { 133, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7733), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7736), 13, "NMelfi@attentigroup.com", "Nicholas", false, false, "Melfi", 12, "System", "System", "NMelfi" },
                    { 117, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7667), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7670), 12, "AInostroza@attentigroup.com", "Alfredo", false, false, "Inostroza", 115, "System", "System", "AInostroza" },
                    { 116, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7662), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7664), 12, "QCuebero@attentigroup.com", "Quincy", false, false, "Cubero", 8, "System", "System", "QCubero" },
                    { 115, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7659), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7662), 12, "ATomasi@attentigroup.com", "Anthony", false, false, "Tomasi", 8, "System", "System", "ATomasi" },
                    { 145, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7807), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7807), 8, "FBorcan@attentigroup.com", "Fulviu", false, false, "Borcan", 129, "System", "System", "FBorcan" },
                    { 146, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7810), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7812), 8, "DBoyd@attentigroup.com", "David", false, false, "Boyd", 129, "System", "System", "DBoyd" },
                    { 147, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7815), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7815), 8, "PHickman@attentigroup.com", "Phil", false, true, "Hickman", 129, "System", "System", "PHickman" },
                    { 14, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7204), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7204), 9, "TMorris@attentigroup.com", "Tim", true, false, "Morris", 1, "System", "System", "TMorris" },
                    { 158, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7861), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7864), 9, "JPate@attentigroup.com", "James", false, false, "Pate", 14, "System", "System", "JPate" },
                    { 159, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7864), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7866), 9, "MTyre@attentigroup.com", "Matt", false, false, "Tyre", 14, "System", "System", "MTyre" },
                    { 160, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7869), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7872), 9, "PMitchell@attentigroup.com", "Patricia", false, false, "Mitchell", 14, "System", "System", "PMitchell" },
                    { 161, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7872), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7875), 9, "RChacon@attentigroup.com", "Robert", false, false, "Chacon", 14, "System", "System", "RChacon" },
                    { 1, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7090), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7115), 10, "ARoese@attentigroup.com", "Arnold", true, false, "Roese", 0, "System", "System", "ARoese" },
                    { 9, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7181), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7184), 10, "MShilling@attentigroup.com", "Mitzi", false, false, "Shilling", 1, "System", "System", "MShilling" },
                    { 6, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7167), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7170), 11, "JAspenleiter@attentigroup.com", "Jeffrey", true, false, "Aspenleiter", 1, "System", "System", "JAspenleiter" },
                    { 89, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7548), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7551), 11, "AThorne@attentigroup.com", "Al", false, false, "Thorne", 6, "System", "System", "AThorne" },
                    { 90, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7554), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7554), 11, "JRoman@attentigroup.com", "John", false, false, "Roman", 6, "System", "System", "JRoman" },
                    { 91, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7556), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7559), 11, "JRestrepo@attentigroup.com", "Juan", false, false, "Restrepo", 6, "System", "System", "JRestrepo" },
                    { 92, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7562), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7562), 11, "WTirado@attentigroup.com", "Wil", false, false, "Tirado", 6, "System", "System", "WTirado" },
                    { 8, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7175), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7178), 12, "MLyon@attentigroup.com", "Matthew", true, false, "Lyon", 1, "System", "System", "MLyon" },
                    { 114, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7656), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7656), 12, "AGibson@attentigroup.com", "Adam", false, false, "Gibson", 8, "System", "System", "AGibson" },
                    { 100, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7596), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7596), 6, "JGonzalez@attentigroup.com", "Joshua", false, false, "Gonzalez", 7, "System", "System", "JGonzalez" },
                    { 156, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7852), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7855), 16, "DLashley@attentigroup.com", "Dane", false, false, "DLashley", 13, "System", "System", "DLashley" },
                    { 99, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7590), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7593), 6, "JHernandez@attentigroup.com", "Jimmy", false, false, "Hernandez", 7, "System", "System", "JHernandez" },
                    { 97, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7582), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7585), 6, "JMachado@attentigroup.com", "Jamie", false, false, "Machado", 7, "System", "System", "JMachado" },
                    { 77, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7497), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7499), 1, "WCorriolan@attentigroup.com", "Worlson", false, false, "Corriolan", 57, "System", "System", "WCorriolan" },
                    { 3, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7155), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7158), 2, "CKavanaugh@attentigroup.com", "Christine", true, false, "Kavanaugh", 1, "System", "System", "CKavanaugh" },
                    { 51, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7360), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7360), 2, "DFrasca@attentigroup.com", "Debbie", false, false, "Frasca", 3, "System", "System", "DFrasca" },
                    { 52, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7363), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7366), 2, "JHart@attentigroup.com", "Jennifer", false, false, "Hart", 3, "System", "System", "JHart" },
                    { 53, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7369), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7369), 2, "WBain@attentigroup.com", "Wendy", false, false, "Bain", 3, "System", "System", "WBain" },
                    { 140, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7764), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7764), 3, "JBaughman@attentigroup.com", "John", false, false, "Baughman", 129, "System", "System", "JBaughman" },
                    { 141, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7790), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7790), 3, "SLyerly@attentigroup.com", "Shirley", false, false, "Lyerly", 129, "System", "System", "SLyerly" },
                    { 76, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7494), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7497), 1, "SLisle@attentigroup.com", "Scott", false, false, "Lisle", 57, "System", "System", "SLisle" },
                    { 142, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7792), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7795), 3, "SDuPont@attentigroup.com", "Stan", false, false, "DuPont", 129, "System", "System", "SDuPont" },
                    { 154, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7844), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7846), 3, "NMejia@attentigroup.com", "Nicolas", false, false, "Mejia", 132, "System", "System", "NMejia" },
                    { 155, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7846), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7849), 3, "SKnowlton@attentigroup.com", "Steven", false, false, "Knowlton", 132, "System", "System", "SKnowlton" },
                    { 4, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7158), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7161), 4, "CElton@attentigroup.com", "Chris", true, false, "Elton", 1, "System", "System", "CElton" },
                    { 54, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7371), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7374), 4, "EVega@attentigroup.com", "Edielsy", false, false, "Vega", 4, "System", "System", "EVega" },
                    { 55, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7377), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7377), 4, "HBeall@attentigroup.com", "Hope", false, false, "Beall", 4, "System", "System", "HBeall" },
                    { 56, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7380), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7383), 4, "KRyan@attentigroup.com", "Kerri", false, false, "Ryan", 4, "System", "System", "KRyan" },
                    { 2, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7150), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7152), 5, "BNixon@attentigroup.com", "Brett", true, false, "Nixon", 1, "System", "System", "BNixon" },
                    { 153, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7838), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7841), 3, "CGuibert@attentigroup.com", "Claudy", false, false, "Guibert", 132, "System", "System", "CGuibert" },
                    { 15, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7206), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7209), 5, "ACabral@attentigroup.com", "Alexandra", true, false, "Cabral", 2, "System", "System", "ACabral" },
                    { 75, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7488), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7491), 1, "MFlowers@attentigroup.com", "Michelle", false, false, "Flowers", 57, "System", "System", "MFlowers" },
                    { 73, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7482), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7482), 1, "MLater@attentigroup.com", "Mary", false, false, "Later", 57, "System", "System", "MLater" },
                    { 57, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7386), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7386), 1, "ABrown@attentigroup.com", "Aaron", true, false, "Brown", 5, "System", "System", "ABrown" },
                    { 58, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7389), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7391), 1, "CViolante@attentigroup.com", "Christopher", true, false, "Violante", 5, "System", "System", "CViolante" },
                    { 59, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7394), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7394), 1, "DDerosiers@attentigroup.com", "Dave", true, false, "Derosiers", 5, "System", "System", "DDerosiers" },
                    { 60, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7397), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7400), 1, "GBlancato@attentigroup.com", "Gina", false, false, "Blancato", 5, "System", "System", "GBlancato" },
                    { 61, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7400), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7403), 1, "JAbernathy@attentigroup.com", "Jason", false, false, "Abernathy", 5, "System", "System", "JAbernathy" },
                    { 62, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7406), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7408), 1, "JRodriguez@attentigroup.com", "Jon", false, false, "Rodriguez", 5, "System", "System", "JRodriguez" },
                    { 63, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7408), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7411), 1, "AKessell@attentigroup.com", "Adam", false, false, "Kessell", 57, "System", "System", "AKessell" },
                    { 74, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7485), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7488), 1, "MCrockett@attentigroup.com", "McKinley", false, false, "Crockett", 57, "System", "System", "MCrockett" },
                    { 64, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7414), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7417), 1, "BOrtiz@attentigroup.com", "Brandon", false, false, "Ortiz", 57, "System", "System", "BOrtiz" },
                    { 66, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7423), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7423), 1, "HFickel@attentigroup.com", "Henry", false, false, "Fickel", 57, "System", "System", "HFickel" },
                    { 67, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7426), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7428), 1, "JCistaro@attentigroup.com", "Jenice", false, false, "Cistaro", 57, "System", "System", "JCistaro" },
                    { 68, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7460), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7462), 1, "JJackson@attentigroup.com", "Joanna", false, false, "Jackson", 57, "System", "System", "JJackson" },
                    { 69, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7462), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7465), 1, "JNyhus@attentigroup.com", "Joshua", false, false, "Nyhus", 57, "System", "System", "JNyhus" },
                    { 70, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7468), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7471), 1, "LOrtiz@attentigroup.com", "Leandro", false, false, "Ortiz", 57, "System", "System", "LOrtiz" },
                    { 71, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7471), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7474), 1, "LMyhre@attentigroup.com", "Linn", false, false, "Sophie Myhre", 57, "System", "System", "LMyhre" },
                    { 72, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7477), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7480), 1, "MValenti@attentigroup.com", "Marc", false, false, "Valenti", 57, "System", "System", "MValenti" },
                    { 65, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7417), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7420), 1, "CPoole@attentigroup.com", "Christopher", false, false, "Poole", 57, "System", "System", "CPoole" },
                    { 16, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7212), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7212), 5, "JRoberts@attentigroup.com", "Jacqueline", true, false, "Roberts", 2, "System", "System", "JRoberts" },
                    { 17, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7215), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7218), 5, "JFerrantino@attentigroup.com", "John", false, false, "Ferrantino", 2, "System", "System", "JFerrantino" },
                    { 18, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7218), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7221), 5, "MPiesco@attentigroup.com", "Mike", true, false, "Piesco", 2, "System", "System", "MPiesco" },
                    { 40, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7312), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7315), 5, "YResse@attentigroup.com", "Yilliam", false, false, "Reese", 18, "System", "System", "YReese" },
                    { 41, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7317), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7317), 5, "AGomez@attentigroup.com", "Adriana", false, false, "Gomez", 19, "System", "System", "AGomez" },
                    { 42, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7320), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7323), 5, "BVillegas@attentigroup.com", "Beatrice", false, false, "Villegas", 19, "System", "System", "BVillegas" },
                    { 43, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7326), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7326), 5, "CGoodwin@attentigroup.com", "Caleb", false, false, "Goodwin", 19, "System", "System", "CGoodwin" },
                    { 44, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7329), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7332), 5, "CAnaya@attentigroup.com", "Cindy", false, false, "Anaya", 19, "System", "System", "CAnaya" },
                    { 45, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7334), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7334), 5, "MRivera@attentigroup.com", "Manuel", false, false, "Rivera", 19, "System", "System", "MRivera" },
                    { 46, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7337), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7340), 5, "SVizcaya@attentigroup.com", "Selene", false, false, "Vizcaya", 19, "System", "System", "SVizcaya" },
                    { 39, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7309), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7309), 5, "RHogue@attentigroup.com", "Renwick", false, false, "Hogue", 18, "System", "System", "RHogue" },
                    { 47, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7343), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7343), 5, "SVizcaya@attentigroup.com", "Selene", false, false, "Vizcaya", 19, "System", "System", "SVizcaya" },
                    { 49, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7352), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7352), 5, "VStanley@attentigroup.com", "Venus", false, false, "Stanley", 19, "System", "System", "VStanley" },
                    { 50, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7354), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7357), 5, "YBarajas@attentigroup.com", "Yesnia", false, false, "Barajas", 19, "System", "System", "YBarajas" },
                    { 7, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7172), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7175), 6, "MWilliamson@attentigroup.com", "Mark", true, false, "Williamson", 1, "System", "System", "MWilliamson" },
                    { 93, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7565), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7568), 6, "AParadelo@attentigroup.com", "Alejandro", false, false, "Paradelo", 7, "System", "System", "AParadelo" },
                    { 94, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7571), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7571), 6, "DWilliamson@attentigroup.com", "Daniel", false, false, "Williamson", 7, "System", "System", "DWilliamson" },
                    { 95, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7573), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7576), 6, "HWeaver@attentigroup.com", "Harry", false, false, "Weaver", 7, "System", "System", "HWeaver" },
                    { 96, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7579), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7579), 6, "HChacon@attentigroup.com", "Helly", false, false, "Chacon", 7, "System", "System", "HChacon" },
                    { 48, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7346), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7349), 5, "TMorena@attentigroup.com", "Tania", false, false, "Morena Ortega", 19, "System", "System", "TMorena" },
                    { 38, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7303), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7306), 5, "MRodriguez@attentigroup.com", "Marlene", false, false, "Rodriguez", 18, "System", "System", "MRodriguez" },
                    { 37, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7300), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7300), 5, "GSoto@attentigroup.com", "Grace", false, false, "Soto", 18, "System", "System", "GSoto" },
                    { 36, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7295), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7298), 5, "CNeal@attentigroup.com", "Cedric", false, false, "Neal", 18, "System", "System", "CNeal" },
                    { 19, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7224), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7226), 5, "TSmith@attentigroup.com", "Timothy", true, false, "Smith", 2, "System", "System", "TSmith" },
                    { 20, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7226), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7229), 5, "CRivera@attentigroup.com", "Carmen", false, false, "Rivera", 15, "System", "System", "CRivera" },
                    { 21, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7232), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7235), 5, "HHay@attentigroup.com", "Heather", false, false, "Hay", 15, "System", "System", "HHay" },
                    { 22, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7235), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7238), 5, "KCaldarola@attentigroup.com", "Kara", false, false, "Caldarola", 15, "System", "System", "KCaldarola" },
                    { 23, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7241), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7243), 5, "WSpencer@attentigroup.com", "William", false, false, "Spencer", 15, "System", "System", "WSpencer" },
                    { 24, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7243), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7246), 5, "YArevalo@attentigroup.com", "Yeison", false, false, "Arevalo-Gutierrez", 15, "System", "System", "YArevalo" },
                    { 25, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7249), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7249), 5, "APagan@attentigroup.com", "Angel", false, false, "Pagan", 16, "System", "System", "APagan" },
                    { 26, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7252), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7255), 5, "DJett@attentigroup.com", "Daniel", false, false, "Jett", 16, "System", "System", "DJett" },
                    { 27, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7258), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7258), 5, "DPridemore@attentigroup.com", "Desiree", false, false, "Pridemore", 16, "System", "System", "DPridemore" },
                    { 28, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7261), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7263), 5, "LAlexander@attentigroup.com", "Lakeisha", false, false, "Alexander", 16, "System", "System", "LAlexander" },
                    { 29, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7266), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7266), 5, "LAlexander@attentigroup.com", "Lana", false, false, "Alexander", 16, "System", "System", "LEwald" },
                    { 30, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7269), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7272), 5, "LRojas@attentigroup.com", "Lani", false, false, "Rojas-Allen", 16, "System", "System", "LRojas" },
                    { 31, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7275), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7275), 5, "LGonzalez@attentigroup.com", "Luis", false, false, "Gonzalez", 16, "System", "System", "LGonzalez" },
                    { 32, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7278), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7280), 5, "SGuyer@attentigroup.com", "Shana", false, false, "Guyer", 16, "System", "System", "SGuyer" },
                    { 33, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7283), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7283), 5, "SWollitz@attentigroup.com", "Stephanie", false, false, "Wollitz", 16, "System", "System", "SWollitz" },
                    { 34, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7286), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7289), 5, "AO'Reilly@attentigroup.com", "Autumn", false, false, "O'Reilly", 18, "System", "System", "AO'Reilly" },
                    { 35, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7292), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7292), 5, "BLanzilotta@attentigroup.com", "Barbara", false, false, "Lanzilotta", 18, "System", "System", "BLanzilotta" },
                    { 98, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7588), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7588), 6, "JPalacios@attentigroup.com", "Janise", false, false, "Palacios", 7, "System", "System", "JPalacios" },
                    { 157, new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7858), new DateTime(2019, 1, 4, 16, 0, 58, 726, DateTimeKind.Local).AddTicks(7858), 16, "JIoannou@attentigroup.com", "Jeannette", false, false, "Ioannou", 13, "System", "System", "JIoannou" }
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
