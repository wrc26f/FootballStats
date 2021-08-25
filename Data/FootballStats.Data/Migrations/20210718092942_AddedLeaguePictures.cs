using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballStats.Data.Migrations
{
    public partial class AddedLeaguePictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Leagues",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Leagues");
        }
    }
}
