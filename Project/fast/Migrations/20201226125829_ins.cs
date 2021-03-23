using Microsoft.EntityFrameworkCore.Migrations;

namespace fast.Migrations
{
    public partial class ins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrunID",
                table: "Sepets");

            migrationBuilder.AddColumn<string>(
                name: "Sanatci",
                table: "Sepets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sanatci",
                table: "Sepets");

            migrationBuilder.AddColumn<int>(
                name: "UrunID",
                table: "Sepets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
