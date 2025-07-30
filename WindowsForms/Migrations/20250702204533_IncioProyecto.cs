using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class IncioProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    _id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    portada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calificacion = table.Column<double>(type: "double", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Argentina" },
                    { 2, false, "Brasil" },
                    { 3, false, "Chile" },
                    { 4, false, "España" },
                    { 5, false, "México" },
                    { 6, false, "Estados Unidos" },
                    { 7, false, "Francia" },
                    { 8, false, "Italia" },
                    { 9, false, "Alemania" },
                    { 10, false, "Japón" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "id", "Eliminado", "_id", "calificacion", "duracion", "portada", "titulo" },
                values: new object[,]
                {
                    { 1, false, null, 8.1999999999999993, 129, "https://image.tmdb.org/t/p/w500/secreto.jpg", "El secreto de sus ojos" },
                    { 2, false, null, 8.5999999999999996, 130, "https://image.tmdb.org/t/p/w500/ciudad.jpg", "Ciudad de Dios" },
                    { 3, false, null, 8.0999999999999996, 154, "https://image.tmdb.org/t/p/w500/amores.jpg", "Amores Perros" },
                    { 4, false, null, 8.5999999999999996, 116, "https://image.tmdb.org/t/p/w500/vida.jpg", "La vida es bella" },
                    { 5, false, null, 8.1999999999999993, 118, "https://image.tmdb.org/t/p/w500/laberinto.jpg", "El laberinto del fauno" },
                    { 6, false, null, 8.5, 112, "https://image.tmdb.org/t/p/w500/intouchables.jpg", "Intouchables" },
                    { 7, false, null, 8.5999999999999996, 125, "https://image.tmdb.org/t/p/w500/spirited.jpg", "Spirited Away" },
                    { 8, false, null, 8.5, 132, "https://image.tmdb.org/t/p/w500/parasite.jpg", "Parasite" },
                    { 9, false, null, 8.8000000000000007, 142, "https://image.tmdb.org/t/p/w500/forrest.jpg", "Forrest Gump" },
                    { 10, false, null, 8.6999999999999993, 148, "https://image.tmdb.org/t/p/w500/inception.jpg", "Inception" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}
