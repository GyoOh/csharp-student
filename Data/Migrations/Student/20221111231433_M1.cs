using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assignment1.Data.Migrations.Student
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityOfResidence = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[,]
                {
                    { 1, "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing" },
                    { 2, "Chilliwack", "jane@douglas.com", "Jane", "Douglas", "604-123-4567", "Nursing" },
                    { 3, "Chilliwack", "tom@gardner.com", "Tom", "Gardner", "604-123-4567", "Nursing" },
                    { 4, "Chilliwack", "ann@lee.com", "Ann", "Lee", "604-123-4567", "Nursing" },
                    { 5, "Chilliwack", "james@jones.com", "James", "Jones", "604-123-4567", "Nursing" },
                    { 6, "Chilliwack", "susn@taylor.com", "Susan", "Taylor", "604-123-4567", "Nursing" },
                    { 7, "Chilliwack", "peter@white.com", "Peter", "White", "604-123-4567", "Nursing" },
                    { 8, "Chilliwack", "philip@fox.com", "Philip", "Fox", "604-123-4567", "Nursing" },
                    { 9, "Chilliwack", "donna@ray.com", "Donna", "Ray", "604-123-4567", "Nursing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
