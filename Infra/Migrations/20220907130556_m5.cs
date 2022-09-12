using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_offres_offres_Offreid",
                table: "offres");

            migrationBuilder.DropTable(
                name: "Offre_Ressource");

            migrationBuilder.DropTable(
                name: "Ressource");

            migrationBuilder.DropIndex(
                name: "IX_offres_Offreid",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Offreid",
                table: "offres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Offreid",
                table: "offres",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ressource",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coûtParH = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ressource", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Offre_Ressource",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    offreid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ressourceid = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nbre_Heure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offre_Ressource", x => x.id);
                    table.ForeignKey(
                        name: "FK_Offre_Ressource_offres_offreid",
                        column: x => x.offreid,
                        principalTable: "offres",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Offre_Ressource_Ressource_Ressourceid",
                        column: x => x.Ressourceid,
                        principalTable: "Ressource",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_offres_Offreid",
                table: "offres",
                column: "Offreid");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_Ressource_offreid",
                table: "Offre_Ressource",
                column: "offreid");

            migrationBuilder.CreateIndex(
                name: "IX_Offre_Ressource_Ressourceid",
                table: "Offre_Ressource",
                column: "Ressourceid");

            migrationBuilder.AddForeignKey(
                name: "FK_offres_offres_Offreid",
                table: "offres",
                column: "Offreid",
                principalTable: "offres",
                principalColumn: "id");
        }
    }
}
