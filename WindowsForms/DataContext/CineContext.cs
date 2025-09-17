using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.DataContext
{
    public class CineContext : DbContext
    {
        // Define DbSets for your entities here
        public virtual DbSet<Pelicula> Peliculas { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }

        public CineContext()
        {
        }

        public CineContext(DbContextOptions<CineContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //creamos una cadena de conexión para el mysql local
                string cnn = "server=127.0.0.1;database=cinecontext;user=root;password=";
                optionsBuilder.UseMySql(cnn, ServerVersion.AutoDetect(cnn));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cargamos los datos iniciales de la base de datos

            modelBuilder.Entity<Pais>().HasData(
                new Pais { id = 1, Nombre = "Argentina", Eliminado = false },
                new Pais { id = 2, Nombre = "Brasil", Eliminado = false },
                new Pais { id = 3, Nombre = "Chile", Eliminado = false },
                new Pais { id = 4, Nombre = "España", Eliminado = false },
                new Pais { id = 5, Nombre = "México", Eliminado = false },
                new Pais { id = 6, Nombre = "Estados Unidos", Eliminado = false },
                new Pais { id = 7, Nombre = "Francia", Eliminado = false },
                new Pais { id = 8, Nombre = "Italia", Eliminado = false },
                new Pais { id = 9, Nombre = "Alemania", Eliminado = false },
                new Pais { id = 10, Nombre = "Japón", Eliminado = false }
            );

            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula
                {
                    id = 1,
                    titulo = "El secreto de sus ojos",
                    duracion = 129,
                    portada = "https://upload.wikimedia.org/wikipedia/en/6/6a/El_secreto_de_sus_ojos_poster.jpg",
                    calificacion = 8.2,
                    Eliminado = false,
                    PaisId = 1 // Asignamos el país de origen
                },
                new Pelicula
                {
                    id = 2,
                    titulo = "Ciudad de Dios",
                    duracion = 130,
                    portada = "https://upload.wikimedia.org/wikipedia/en/1/10/CidadedeDeus.jpg",
                    calificacion = 8.6,
                    Eliminado = false,
                    PaisId = 2 // Asignamos el país de origen
                },
                new Pelicula
                {
                    id = 3,
                    titulo = "Relatos salvajes",
                    duracion = 122,
                    portada = "https://upload.wikimedia.org/wikipedia/en/7/7c/Relatos_Salvajes_poster.jpg",
                    calificacion = 8.1,
                    Eliminado = false,
                    PaisId = 1
                },
                new Pelicula
                {
                    id = 4,
                    titulo = "Amores perros",
                    duracion = 154,
                    portada = "https://upload.wikimedia.org/wikipedia/en/6/6d/Amores_perros_poster.jpg",
                    calificacion = 8.1,
                    Eliminado = false,
                    PaisId = 1
                },
                new Pelicula
                {
                    id = 5,
                    titulo = "La vida es bella",
                    duracion = 116,
                    portada = "https://upload.wikimedia.org/wikipedia/en/7/7c/Vitaebella.jpg",
                    calificacion = 8.6,
                    Eliminado = false,
                    PaisId = 8
                },
                new Pelicula
                {
                    id = 6,
                    titulo = "El laberinto del fauno",
                    duracion = 118,
                    portada = "https://upload.wikimedia.org/wikipedia/en/6/67/Pans_labyrinth.jpg",
                    calificacion = 8.2,
                    Eliminado = false,
                    PaisId = 6
                },
                new Pelicula
                {
                    id = 7,
                    titulo = "Forrest Gump",
                    duracion = 142,
                    portada = "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg",
                    calificacion = 8.8,
                    Eliminado = false,
                    PaisId = 6 // Asignamos el país de origen
                },
                new Pelicula
                {
                    id = 8,
                    titulo = "Parásitos",
                    duracion = 132,
                    portada = "https://upload.wikimedia.org/wikipedia/en/5/53/Parasite_%282019_film%29.png",
                    calificacion = 8.5,
                    Eliminado = false,
                    PaisId = 10 // Asignamos el país de origen
                },
                new Pelicula
                {
                    id = 9,
                    titulo = "El viaje de Chihiro",
                    duracion = 125,
                    portada = "https://upload.wikimedia.org/wikipedia/en/3/30/Spirited_Away_poster.JPG",
                    calificacion = 8.6,
                    Eliminado = false,
                    PaisId = 10
                },
                new Pelicula
                {
                    id = 10,
                    titulo = "Cinema Paradiso",
                    duracion = 155,
                    portada = "https://upload.wikimedia.org/wikipedia/en/8/88/CinemaParadiso.jpg",
                    calificacion = 8.5,
                    Eliminado = false,
                    PaisId = 6
                }
            );

            // Configuramos las querys para que no devuelvan los elementos eliminados
            modelBuilder.Entity<Pais>().HasQueryFilter(p => !p.Eliminado);
            modelBuilder.Entity<Pelicula>().HasQueryFilter(p => !p.Eliminado);
        }



    }
}
