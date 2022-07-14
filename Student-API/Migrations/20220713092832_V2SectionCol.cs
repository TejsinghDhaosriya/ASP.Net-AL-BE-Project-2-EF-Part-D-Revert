using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_API.Migrations
{
    public partial class V2SectionCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "section",
                table: "students");
        }
    }
}
