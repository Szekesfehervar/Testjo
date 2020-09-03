using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class ah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Vek",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vek",
                table: "Users");
        }
    }
}
