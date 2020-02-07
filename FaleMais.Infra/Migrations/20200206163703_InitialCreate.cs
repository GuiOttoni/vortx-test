using Microsoft.EntityFrameworkCore.Migrations;

namespace FaleMais.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarifa",
                columns: table => new
                {
                    Origem = table.Column<int>(nullable: false),
                    Destino = table.Column<int>(nullable: false),
                    PrecoMinuto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa", x => new { x.Destino, x.Origem });
                });

            migrationBuilder.InsertData(
                table: "Tarifa",
                columns: new[] { "Destino", "Origem", "PrecoMinuto" },
                values: new object[] { 16, 11, 1.8999999999999999 });

            migrationBuilder.InsertData(
                table: "Tarifa",
                columns: new[] { "Destino", "Origem", "PrecoMinuto" },
                values: new object[] { 17, 11, 1.7 });

            migrationBuilder.InsertData(
                table: "Tarifa",
                columns: new[] { "Destino", "Origem", "PrecoMinuto" },
                values: new object[] { 18, 11, 0.90000000000000002 });

            migrationBuilder.InsertData(
                table: "Tarifa",
                columns: new[] { "Destino", "Origem", "PrecoMinuto" },
                values: new object[] { 11, 16, 2.8999999999999999 });

            migrationBuilder.InsertData(
                table: "Tarifa",
                columns: new[] { "Destino", "Origem", "PrecoMinuto" },
                values: new object[] { 11, 17, 2.7000000000000002 });

            migrationBuilder.InsertData(
                table: "Tarifa",
                columns: new[] { "Destino", "Origem", "PrecoMinuto" },
                values: new object[] { 11, 18, 1.8999999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarifa");
        }
    }
}
