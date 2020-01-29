using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class AlterUser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Usuario",
                maxLength: 1,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Usuario");
        }
    }
}
