using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class RenameImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Imagem_ImagemId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Imagem");

            migrationBuilder.CreateTable(
                name: "ImagemUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemUsuario", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_ImagemUsuario_ImagemId",
                table: "Usuario",
                column: "ImagemId",
                principalTable: "ImagemUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_ImagemUsuario_ImagemId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "ImagemUsuario");

            migrationBuilder.CreateTable(
                name: "Imagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagem", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Imagem_ImagemId",
                table: "Usuario",
                column: "ImagemId",
                principalTable: "Imagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
