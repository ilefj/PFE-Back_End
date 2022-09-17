using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class m44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Qte_H_Siege_Site",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total_Cout_Offre",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total_Marge_Brut",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total_Marge_Nette",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total_Marge_Nette_Par_Pen",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total_Prix_Proposition",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total_Prix_Revient",
                table: "offres",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CoutParEmp",
                table: "Offre_Employe",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Marge_Brut",
                table: "Offre_Employe",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Marge_nette",
                table: "Offre_Employe",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Marge_nette_PerPen",
                table: "Offre_Employe",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Prix_Proposition",
                table: "Offre_Employe",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qte_H_Siege_Site",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Total_Cout_Offre",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Total_Marge_Brut",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Total_Marge_Nette",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Total_Marge_Nette_Par_Pen",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Total_Prix_Proposition",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "Total_Prix_Revient",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "CoutParEmp",
                table: "Offre_Employe");

            migrationBuilder.DropColumn(
                name: "Marge_Brut",
                table: "Offre_Employe");

            migrationBuilder.DropColumn(
                name: "Marge_nette",
                table: "Offre_Employe");

            migrationBuilder.DropColumn(
                name: "Marge_nette_PerPen",
                table: "Offre_Employe");

            migrationBuilder.DropColumn(
                name: "Prix_Proposition",
                table: "Offre_Employe");
        }
    }
}
