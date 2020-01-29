using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class AlterUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_ImagemUsuario_ImagemUsuarioId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ImagemUsuarioId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ImagemUsuarioId",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "ImagemUsuarioId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ImagemUsuarioId",
                table: "Usuario",
                column: "ImagemUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_ImagemUsuario_ImagemUsuarioId",
                table: "Usuario",
                column: "ImagemUsuarioId",
                principalTable: "ImagemUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
