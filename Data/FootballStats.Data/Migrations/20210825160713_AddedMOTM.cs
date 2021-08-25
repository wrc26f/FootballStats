using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballStats.Data.Migrations
{
    public partial class AddedMOTM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMatchOfTheDay",
                table: "Matches",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMatchOfTheDay",
                table: "Matches");
        }
    }
}
