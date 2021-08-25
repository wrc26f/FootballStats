using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballStats.Data.Migrations
{
    public partial class AddedHomeAndAwayGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwayGoals",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeGoals",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayGoals",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HomeGoals",
                table: "Matches");
        }
    }
}
