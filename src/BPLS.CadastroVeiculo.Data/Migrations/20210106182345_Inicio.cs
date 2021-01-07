using Microsoft.EntityFrameworkCore.Migrations;

namespace BPLS.CadastroVeiculo.Data.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    IdModelo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.IdModelo);
                });

            migrationBuilder.CreateTable(
                name: "TiposVeiculo",
                columns: table => new
                {
                    IdTipoVeiculo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposVeiculo", x => x.IdTipoVeiculo);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    IdVeiculo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModelo = table.Column<long>(type: "bigint", nullable: false),
                    AnoFabricacao = table.Column<int>(type: "INT", nullable: false),
                    AnoModelo = table.Column<int>(type: "INT", nullable: false),
                    IdTipoVeiculo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_Veiculos_Modelos_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "Modelos",
                        principalColumn: "IdModelo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_TiposVeiculo_IdTipoVeiculo",
                        column: x => x.IdTipoVeiculo,
                        principalTable: "TiposVeiculo",
                        principalColumn: "IdTipoVeiculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_IdModelo",
                table: "Veiculos",
                column: "IdModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_IdTipoVeiculo",
                table: "Veiculos",
                column: "IdTipoVeiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "TiposVeiculo");
        }
    }
}
