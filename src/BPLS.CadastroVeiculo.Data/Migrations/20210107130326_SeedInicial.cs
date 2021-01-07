using Microsoft.EntityFrameworkCore.Migrations;

namespace BPLS.CadastroVeiculo.Data.Migrations
{
    public partial class SeedInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_TiposVeiculo_IdTipoVeiculo",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_IdTipoVeiculo",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "IdTipoVeiculo",
                table: "Veiculos");

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

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "AnoFabricacao", "AnoModelo", "IdModelo" },
                values: new object[] { 1L, 2021, 2020, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "IdModelo",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TiposVeiculo",
                keyColumn: "IdTipoVeiculo",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Modelos",
                keyColumn: "IdModelo",
                keyValue: 1L);

            migrationBuilder.AddColumn<long>(
                name: "IdTipoVeiculo",
                table: "Veiculos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_IdTipoVeiculo",
                table: "Veiculos",
                column: "IdTipoVeiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_TiposVeiculo_IdTipoVeiculo",
                table: "Veiculos",
                column: "IdTipoVeiculo",
                principalTable: "TiposVeiculo",
                principalColumn: "IdTipoVeiculo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
