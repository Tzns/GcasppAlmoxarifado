using Microsoft.EntityFrameworkCore.Migrations;

namespace Almoxarifado.Migrations
{
    public partial class primeiroupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada");

            migrationBuilder.DropForeignKey(
                name: "FK_GentradaItem_GProduto_GProdutoId",
                table: "GentradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GProduto_GProdutoUnidade_GPrudutoUnidadeId",
                table: "GProduto");

            migrationBuilder.AlterColumn<int>(
                name: "GPrudutoUnidadeId",
                table: "GProduto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ContaContabil",
                table: "GProduto",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "GProdutoId",
                table: "GentradaItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GFornecedorId",
                table: "Gentrada",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId",
                principalTable: "GFornecedor",
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
                name: "FK_GProduto_GProdutoUnidade_GPrudutoUnidadeId",
                table: "GProduto",
                column: "GPrudutoUnidadeId",
                principalTable: "GProdutoUnidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada");

            migrationBuilder.DropForeignKey(
                name: "FK_GentradaItem_GProduto_GProdutoId",
                table: "GentradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GProduto_GProdutoUnidade_GPrudutoUnidadeId",
                table: "GProduto");

            migrationBuilder.AlterColumn<int>(
                name: "GPrudutoUnidadeId",
                table: "GProduto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ContaContabil",
                table: "GProduto",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GProdutoId",
                table: "GentradaItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GFornecedorId",
                table: "Gentrada",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Gentrada_GFornecedor_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId",
                principalTable: "GFornecedor",
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
                name: "FK_GProduto_GProdutoUnidade_GPrudutoUnidadeId",
                table: "GProduto",
                column: "GPrudutoUnidadeId",
                principalTable: "GProdutoUnidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
