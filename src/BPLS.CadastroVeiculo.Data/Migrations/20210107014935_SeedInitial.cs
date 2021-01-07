using Microsoft.EntityFrameworkCore.Migrations;

namespace BPLS.CadastroVeiculo.Data.Migrations
{
    public partial class SeedInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "IdModelo", "Descricao" },
                values: new object[] { 1L, "FH" });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "IdModelo", "Descricao" },
                values: new object[] { 2L, "FM" });

            migrationBuilder.InsertData(
                table: "TiposVeiculo",
                columns: new[] { "IdTipoVeiculo", "Descricao" },
                values: new object[] { 1L, "Caminhão" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "IdModelo",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "IdModelo",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TiposVeiculo",
                keyColumn: "IdTipoVeiculo",
                keyValue: 1L);
        }
    }
}
