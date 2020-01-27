using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class AlterUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entidade");

            migrationBuilder.AddColumn<int>(
                name: "ImagemId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ImagemId",
                table: "Usuario",
                column: "ImagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Imagem_ImagemId",
                table: "Usuario",
                column: "ImagemId",
                principalTable: "Imagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Imagem_ImagemId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ImagemId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ImagemId",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "Entidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidade", x => x.Id);
                });
        }
    }
}
