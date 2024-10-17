using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculadoraPekus.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Operação = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorA = table.Column<decimal>(type: "DECIMAL(38,17)", nullable: false),
                    ValorB = table.Column<decimal>(type: "DECIMAL(38,17)", nullable: false),
                    Resultado = table.Column<decimal>(type: "DECIMAL(38,17)", nullable: false),
                    DataCalculo = table.Column<DateTime>(type: "DATETIME2", nullable: false, defaultValue: new DateTime(2024, 10, 17, 16, 49, 17, 118, DateTimeKind.Local).AddTicks(9559))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculos");
        }
    }
}
