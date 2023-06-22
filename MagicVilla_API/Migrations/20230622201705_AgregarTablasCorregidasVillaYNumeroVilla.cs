using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablasCorregidasVillaYNumeroVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Tarifa",
                table: "Villas",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "MetrosCuadrados",
                table: "Villas",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados", "Tarifa" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9444), 70f, 500f });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados", "Tarifa" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9457), 40f, 800f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Tarifa",
                table: "Villas",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "MetrosCuadrados",
                table: "Villas",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados", "Tarifa" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 52, 10, 688, DateTimeKind.Local).AddTicks(4675), new DateTime(2023, 6, 21, 10, 52, 10, 688, DateTimeKind.Local).AddTicks(4660), 70.0, 500.0 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados", "Tarifa" },
                values: new object[] { new DateTime(2023, 6, 21, 10, 52, 10, 688, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 6, 21, 10, 52, 10, 688, DateTimeKind.Local).AddTicks(4677), 40.0, 800.0 });
        }
    }
}
