using Microsoft.EntityFrameworkCore.Migrations;

namespace fast.Migrations
{
    public partial class hadi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Sepets");

            migrationBuilder.AddColumn<string>(
                name: "UserMail",
                table: "Sepets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserMail",
                table: "Sepets");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Sepets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
