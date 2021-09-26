using Microsoft.EntityFrameworkCore.Migrations;

namespace Almoxarifado.Migrations
{
    public partial class arrumandoCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada");

            migrationBuilder.DropForeignKey(
                name: "FK_GentradaItem_Gentrada_GEntradaId",
                table: "GentradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GentradaItem_GProduto_GProdutoId",
                table: "GentradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GEstoque_GProduto_Id",
                table: "GEstoque");

            migrationBuilder.DropIndex(
                name: "IX_GentradaItem_GProdutoId",
                table: "GentradaItem");

            migrationBuilder.DropIndex(
                name: "IX_Gentrada_GFornecedorId",
                table: "Gentrada");

            migrationBuilder.CreateIndex(
                name: "IX_GentradaItem_GProdutoId",
                table: "GentradaItem",
                column: "GProdutoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gentrada_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId",
                principalTable: "GFornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GentradaItem_Gentrada_GEntradaId",
                table: "GentradaItem",
                column: "GEntradaId",
                principalTable: "Gentrada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GentradaItem_GProduto_GProdutoId",
                table: "GentradaItem",
                column: "GProdutoId",
                principalTable: "GProduto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GEstoque_GProduto_Id",
                table: "GEstoque",
                column: "Id",
                principalTable: "GProduto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada");

            migrationBuilder.DropForeignKey(
                name: "FK_GentradaItem_Gentrada_GEntradaId",
                table: "GentradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GentradaItem_GProduto_GProdutoId",
                table: "GentradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GEstoque_GProduto_Id",
                table: "GEstoque");

            migrationBuilder.DropIndex(
                name: "IX_GentradaItem_GProdutoId",
                table: "GentradaItem");

            migrationBuilder.DropIndex(
                name: "IX_Gentrada_GFornecedorId",
                table: "Gentrada");

            migrationBuilder.CreateIndex(
                name: "IX_GentradaItem_GProdutoId",
                table: "GentradaItem",
                column: "GProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gentrada_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId",
                principalTable: "GFornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GentradaItem_Gentrada_GEntradaId",
                table: "GentradaItem",
                column: "GEntradaId",
                principalTable: "Gentrada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GentradaItem_GProduto_GProdutoId",
                table: "GentradaItem",
                column: "GProdutoId",
                principalTable: "GProduto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GEstoque_GProduto_Id",
                table: "GEstoque",
                column: "Id",
                principalTable: "GProduto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
