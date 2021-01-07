using Microsoft.EntityFrameworkCore.Migrations;

namespace BPLS.CadastroVeiculo.Data.Migrations
{
    public partial class SeedComplemento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "AnoFabricacao", "AnoModelo", "IdModelo", "IdTipoVeiculo" },
                values: new object[] { 1L, 2021, 2020, 1L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: 1L);
        }
    }
}
