using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class Migracao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuario",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
