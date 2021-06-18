using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroDeQuejas.Data.Migrations
{
    public partial class UpdateRegistroAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistroComplaints",
                table: "Registros",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistroDependency",
                table: "Registros",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistroEmail",
                table: "Registros",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistroEvidence",
                table: "Registros",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistroPosition",
                table: "Registros",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistroRelation",
                table: "Registros",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistroComplaints",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "RegistroDependency",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "RegistroEmail",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "RegistroEvidence",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "RegistroPosition",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "RegistroRelation",
                table: "Registros");
        }
    }
}
