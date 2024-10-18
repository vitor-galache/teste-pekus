using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculadoraPekus.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorB",
                table: "Calculos",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorA",
                table: "Calculos",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Resultado",
                table: "Calculos",
                type: "DECIMAL(38,17)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCalculo",
                table: "Calculos",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 18, 11, 24, 14, 727, DateTimeKind.Local).AddTicks(8923),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValue: new DateTime(2024, 10, 17, 16, 49, 17, 118, DateTimeKind.Local).AddTicks(9559));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorB",
                table: "Calculos",
                type: "DECIMAL(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorA",
                table: "Calculos",
                type: "DECIMAL(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Resultado",
                table: "Calculos",
                type: "DECIMAL(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(38,17)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCalculo",
                table: "Calculos",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 16, 49, 17, 118, DateTimeKind.Local).AddTicks(9559),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2",
                oldDefaultValue: new DateTime(2024, 10, 18, 11, 24, 14, 727, DateTimeKind.Local).AddTicks(8923));
        }
    }
}
