using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTourProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentTime = table.Column<string>(nullable: true),
                    Taken = table.Column<bool>(nullable: false),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    AppointmentId = table.Column<int>(nullable: false),
                    AppointmentTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 1, "8 AM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 2, "9 AM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 3, "10 AM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 4, "11 AM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 5, "12 AM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 6, "1 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 7, "2 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 8, "3 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 9, "4 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 10, "5 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 11, "6 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 12, "7 PM", null, false });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime", "Date", "Taken" },
                values: new object[] { 13, "8 PM", null, false });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "AppointmentId", "AppointmentTime", "Date", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 1, 1, null, "3/25/22", "sarahlolmstead999@gmail.com", "Sarah's Group", 2, "801-435-1276" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "AppointmentId", "AppointmentTime", "Date", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 2, 2, null, "4/18/22", "profhilton@gmail.com", "Spencer's Group", 8, "385-789-6932" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
