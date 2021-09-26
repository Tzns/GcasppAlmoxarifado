using Microsoft.EntityFrameworkCore.Migrations;

namespace Almoxarifado.Migrations
{
    public partial class unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_GProduto_Codigo",
                table: "GProduto",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GProduto_Descricao",
                table: "GProduto",
                column: "Descricao",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GProduto_Codigo",
                table: "GProduto");

            migrationBuilder.DropIndex(
                name: "IX_GProduto_Descricao",
                table: "GProduto");
        }
    }
}
