using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almoxarifado.Migrations
{
    public partial class saidas : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_GentradaItem",
                table: "GentradaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gentrada",
                table: "Gentrada");

            migrationBuilder.RenameTable(
                name: "GentradaItem",
                newName: "GEntradaItem");

            migrationBuilder.RenameTable(
                name: "Gentrada",
                newName: "GEntrada");

            migrationBuilder.RenameIndex(
                name: "IX_GentradaItem_GProdutoId",
                table: "GEntradaItem",
                newName: "IX_GEntradaItem_GProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_GentradaItem_GEntradaId",
                table: "GEntradaItem",
                newName: "IX_GEntradaItem_GEntradaId");

            migrationBuilder.RenameIndex(
                name: "IX_Gentrada_GFornecedorId",
                table: "GEntrada",
                newName: "IX_GEntrada_GFornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GEntradaItem",
                table: "GEntradaItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GEntrada",
                table: "GEntrada",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "GSaida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GSaida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GSaidaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GSaidaId = table.Column<int>(type: "int", nullable: false),
                    GProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "money", nullable: false),
                    PrecoMedio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GSaidaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GSaidaItem_GProduto_GProdutoId",
                        column: x => x.GProdutoId,
                        principalTable: "GProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GSaidaItem_GSaida_GSaidaId",
                        column: x => x.GSaidaId,
                        principalTable: "GSaida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GSaidaItem_GProdutoId",
                table: "GSaidaItem",
                column: "GProdutoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GSaidaItem_GSaidaId",
                table: "GSaidaItem",
                column: "GSaidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_GEntrada_GFornecedor_GFornecedorId",
                table: "GEntrada",
                column: "GFornecedorId",
                principalTable: "GFornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GEntradaItem_GEntrada_GEntradaId",
                table: "GEntradaItem",
                column: "GEntradaId",
                principalTable: "GEntrada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GEntradaItem_GProduto_GProdutoId",
                table: "GEntradaItem",
                column: "GProdutoId",
                principalTable: "GProduto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GEntrada_GFornecedor_GFornecedorId",
                table: "GEntrada");

            migrationBuilder.DropForeignKey(
                name: "FK_GEntradaItem_GEntrada_GEntradaId",
                table: "GEntradaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_GEntradaItem_GProduto_GProdutoId",
                table: "GEntradaItem");

            migrationBuilder.DropTable(
                name: "GSaidaItem");

            migrationBuilder.DropTable(
                name: "GSaida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GEntradaItem",
                table: "GEntradaItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GEntrada",
                table: "GEntrada");

            migrationBuilder.RenameTable(
                name: "GEntradaItem",
                newName: "GentradaItem");

            migrationBuilder.RenameTable(
                name: "GEntrada",
                newName: "Gentrada");

            migrationBuilder.RenameIndex(
                name: "IX_GEntradaItem_GProdutoId",
                table: "GentradaItem",
                newName: "IX_GentradaItem_GProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_GEntradaItem_GEntradaId",
                table: "GentradaItem",
                newName: "IX_GentradaItem_GEntradaId");

            migrationBuilder.RenameIndex(
                name: "IX_GEntrada_GFornecedorId",
                table: "Gentrada",
                newName: "IX_Gentrada_GFornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GentradaItem",
                table: "GentradaItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gentrada",
                table: "Gentrada",
                column: "Id");

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
        }
    }
}
