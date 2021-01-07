using Microsoft.EntityFrameworkCore.Migrations;

namespace BPLS.CadastroVeiculo.Data.Migrations
{
    public partial class ajusteDominioRelacionamentoTipoVeiculo : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdTipoVeiculo",
                table: "Veiculos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: 1L,
                column: "IdTipoVeiculo",
                value: 1L);

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
