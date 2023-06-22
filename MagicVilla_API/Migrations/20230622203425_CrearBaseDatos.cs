using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class CrearBaseDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(8013), new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(8013) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 6, 22, 14, 17, 5, 77, DateTimeKind.Local).AddTicks(9457) });
        }
    }
}
