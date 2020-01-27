using Microsoft.EntityFrameworkCore.Migrations;

namespace Dwd.Lab.Repositorio.Migrations
{
    public partial class AlterProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Imagem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imagem_ProdutoId",
                table: "Imagem",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagem_Produto_ProdutoId",
                table: "Imagem",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagem_Produto_ProdutoId",
                table: "Imagem");

            migrationBuilder.DropIndex(
                name: "IX_Imagem_ProdutoId",
                table: "Imagem");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Imagem");
        }
    }
}
