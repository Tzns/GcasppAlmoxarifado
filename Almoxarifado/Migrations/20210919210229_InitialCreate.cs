using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almoxarifado.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GFornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GFornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GProdutoUnidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sigla = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GProdutoUnidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gentrada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    GFornecedorId = table.Column<int>(type: "int", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empenho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gentrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gentrada_GFornecedor_GFornecedorId",
                        column: x => x.GFornecedorId,
                        principalTable: "GFornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GPrudutoUnidadeId = table.Column<int>(type: "int", nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContaContabil = table.Column<long>(type: "bigint", nullable: false),
                    CAEDespesa = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GProduto_GProdutoUnidade_GPrudutoUnidadeId",
                        column: x => x.GPrudutoUnidadeId,
                        principalTable: "GProdutoUnidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GentradaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GEntradaId = table.Column<int>(type: "int", nullable: false),
                    GProdutoId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "money", nullable: false),
                    PrecoMedio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GentradaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GentradaItem_Gentrada_GEntradaId",
                        column: x => x.GEntradaId,
                        principalTable: "Gentrada",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GentradaItem_GProduto_GProdutoId",
                        column: x => x.GProdutoId,
                        principalTable: "GProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GEstoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "money", nullable: false),
                    PrecoMedio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEstoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GEstoque_GProduto_Id",
                        column: x => x.Id,
                        principalTable: "GProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gentrada_GFornecedorId",
                table: "Gentrada",
                column: "GFornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_GentradaItem_GEntradaId",
                table: "GentradaItem",
                column: "GEntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_GentradaItem_GProdutoId",
                table: "GentradaItem",
                column: "GProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_GProduto_GPrudutoUnidadeId",
                table: "GProduto",
                column: "GPrudutoUnidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GentradaItem");

            migrationBuilder.DropTable(
                name: "GEstoque");

            migrationBuilder.DropTable(
                name: "Gentrada");

            migrationBuilder.DropTable(
                name: "GProduto");

            migrationBuilder.DropTable(
                name: "GFornecedor");

            migrationBuilder.DropTable(
                name: "GProdutoUnidade");
        }
    }
}
