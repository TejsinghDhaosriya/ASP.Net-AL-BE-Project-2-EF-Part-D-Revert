using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_API.Migrations
{
    public partial class V3AddYearOfEnrollmentAndRemoveSectionCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "section",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "year_of_enrollment",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 2020);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year_of_enrollment",
                table: "students");

            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NA");
        }
    }
}
