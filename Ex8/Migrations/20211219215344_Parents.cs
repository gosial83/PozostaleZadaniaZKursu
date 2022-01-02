using Microsoft.EntityFrameworkCore.Migrations;

namespace Ex8.Migrations
{
    public partial class Parents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Student",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersName",
                table: "Student",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "MothersName",
                table: "Student");
        }
    }
}
