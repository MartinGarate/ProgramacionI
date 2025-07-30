using Microsoft.EntityFrameworkCore;
using WindowsForms.Models;

namespace WindowsForms.DataContext
{
    public class CineContext : DbContext
    {
        // Definir DbSet para cada entidad
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
                // Cadena de conexión para MySQL local
                string connectionString = "server=127.0.0.1;database=cinecontext;user=root;password=";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Datos semillas para Paises
            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, Nombre = "Argentina", Eliminado = false },
                new Pais { Id = 2, Nombre = "Brasil", Eliminado = false },
                new Pais { Id = 3, Nombre = "Chile", Eliminado = false },
                new Pais { Id = 4, Nombre = "España", Eliminado = false },
                new Pais { Id = 5, Nombre = "México", Eliminado = false },
                new Pais { Id = 6, Nombre = "Estados Unidos", Eliminado = false },
                new Pais { Id = 7, Nombre = "Francia", Eliminado = false },
                new Pais { Id = 8, Nombre = "Italia", Eliminado = false },
                new Pais { Id = 9, Nombre = "Alemania", Eliminado = false },
                new Pais { Id = 10, Nombre = "Japón", Eliminado = false }
            );

            // Datos semillas para Peliculas (únicas, con PaisId asignado)
            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula { _id = "1", titulo = "El secreto de sus ojos", duracion = 129, portada = "https://image.tmdb.org/t/p/w500/secreto.jpg", calificacion = 8.2, PaisId = 1, Eliminado = false },
                new Pelicula { _id = "2", titulo = "Ciudad de Dios", duracion = 130, portada = "https://image.tmdb.org/t/p/w500/ciudad.jpg", calificacion = 8.6, PaisId = 2, Eliminado = false },
                new Pelicula { _id = "3", titulo = "Amores Perros", duracion = 154, portada = "https://image.tmdb.org/t/p/w500/amores.jpg", calificacion = 8.1, PaisId = 5, Eliminado = false },
                new Pelicula { _id = "4", titulo = "La vida es bella", duracion = 116, portada = "https://image.tmdb.org/t/p/w500/vida.jpg", calificacion = 8.6, PaisId = 8, Eliminado = false },
                new Pelicula { _id = "5", titulo = "El laberinto del fauno", duracion = 118, portada = "https://image.tmdb.org/t/p/w500/laberinto.jpg", calificacion = 8.2, PaisId = 5, Eliminado = false },
                new Pelicula { _id = "6", titulo = "Intouchables", duracion = 112, portada = "https://image.tmdb.org/t/p/w500/intouchables.jpg", calificacion = 8.5, PaisId = 7, Eliminado = false },
                new Pelicula { _id = "7", titulo = "Spirited Away", duracion = 125, portada = "https://image.tmdb.org/t/p/w500/spirited.jpg", calificacion = 8.6, PaisId = 10, Eliminado = false },
                new Pelicula { _id = "8", titulo = "Parasite", duracion = 132, portada = "https://image.tmdb.org/t/p/w500/parasite.jpg", calificacion = 8.5, PaisId = 6, Eliminado = false },
                new Pelicula { _id = "9", titulo = "Forrest Gump", duracion = 142, portada = "https://image.tmdb.org/t/p/w500/forrest.jpg", calificacion = 8.8, PaisId = 6, Eliminado = false },
                new Pelicula { _id = "10", titulo = "Inception", duracion = 148, portada = "https://image.tmdb.org/t/p/w500/inception.jpg", calificacion = 8.7, PaisId = 6, Eliminado = false }
            );

            // Configuración de query filters para omitir los eliminados
            modelBuilder.Entity<Pais>().HasQueryFilter(p => !p.Eliminado);
            modelBuilder.Entity<Pelicula>().HasQueryFilter(p => !p.Eliminado);
        }
    }
}