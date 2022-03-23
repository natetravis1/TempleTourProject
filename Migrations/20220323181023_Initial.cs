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
                    AppointmentTime = table.Column<string>(nullable: true)
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
                    Date = table.Column<string>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    AppointmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Groups_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 1, "8 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 2, "9 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 3, "10 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 4, "11 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 5, "12 AM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 6, "1 PM" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentTime" },
                values: new object[] { 7, "2 PM" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "AppointmentId", "Date", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 1, 1, "3/25/22", "sarahlolmstead999@gmail.com", "Sarah's Group", 2, "801-435-1276" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "AppointmentId", "Date", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 2, 2, "4/18/22", "profhilton@gmail.com", "Spencer's Group", 8, "385-789-6932" });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AppointmentId",
                table: "Groups",
                column: "AppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
