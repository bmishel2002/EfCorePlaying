using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCorePlaying.Migrations
{
    public partial class EsitimateReadInMinutes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EsitimateReadInMinutes",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsitimateReadInMinutes",
                table: "Blogs");
        }
    }
}
