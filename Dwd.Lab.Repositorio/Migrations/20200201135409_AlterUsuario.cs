using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class AlterUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ativo",
                table: "Usuario",
                type: "char",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Usuario");
        }
    }
}
