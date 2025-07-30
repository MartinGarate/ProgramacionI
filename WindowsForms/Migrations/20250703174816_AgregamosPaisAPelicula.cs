using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosPaisAPelicula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Peliculas",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_PaisId",
                table: "Peliculas",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Paises_PaisId",
                table: "Peliculas",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Paises_PaisId",
                table: "Peliculas");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_PaisId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Peliculas");
        }
    }
}
