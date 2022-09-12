using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "employe",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_employe_UserId",
                table: "employe",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_employe_AspNetUsers_UserId",
                table: "employe",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employe_AspNetUsers_UserId",
                table: "employe");

            migrationBuilder.DropIndex(
                name: "IX_employe_UserId",
                table: "employe");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "employe");
        }
    }
}
