using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class AlterUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Usuario",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);
        }
    }
}
