using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballStats.Data.Migrations
{
    public partial class RemovedAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Footballers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Footballers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
