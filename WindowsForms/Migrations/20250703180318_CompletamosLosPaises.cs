using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class CompletamosLosPaises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 1,
                column: "PaisId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 2,
                column: "PaisId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 3,
                column: "PaisId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 4,
                column: "PaisId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 5,
                column: "PaisId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 6,
                column: "PaisId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 7,
                column: "PaisId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 8,
                column: "PaisId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 9,
                column: "PaisId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 10,
                column: "PaisId",
                value: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 1,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 2,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 3,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 4,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 5,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 6,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 7,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 8,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 9,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 10,
                column: "PaisId",
                value: null);
        }
    }
}
