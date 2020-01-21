using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class Migracao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Usuario",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Usuario");
        }
    }
}
