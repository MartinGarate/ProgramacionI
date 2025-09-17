using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;
using System.Net.Http.Json;
using MySql.Data.MySqlClient;

namespace WindowsForms.Services
{
    public class PeliculaADOService
    {
        // Cadena de conexión a MySQL para usuario root y contraseña root
        string connectionString = "server=127.0.0.1;user=root; password=;Database=programacion1_2025;";

        public async Task<List<Pelicula>?> GetAllAsync()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand("SELECT * FROM peliculas", connection);
                var reader = await command.ExecuteReaderAsync();
                List<Pelicula> peliculas = new List<Pelicula>();
                while (await reader.ReadAsync())
                {
                    Pelicula pelicula = new Pelicula
                    {
                        //id = Convert.ToInt32(reader["id"]),
                        //titulo = reader["titulo"].ToString(),
                        //duracion = Convert.ToInt32(reader["duracion"]),
                        //portada = reader["portada"].ToString(),
                        //calificacion = Convert.ToDouble(reader["calificacion"])
                    };
                    peliculas.Add(pelicula);
                }
                return peliculas;
            }
        }

        public async Task<bool> DeleteAsync(int? id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand($"DELETE FROM peliculas WHERE id={id}", connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
        }

        public async Task<bool> UpdateAsync(Pelicula pelicula)
        {
            // Ejemplo: se ejecuta algún código de actualización, actualmente no opera.
            await Task.CompletedTask;
            return false;
        }

        public async Task<bool> AddAsync(Pelicula pelicula)
        {
            // Ejemplo: se ejecuta algún código de inserción, actualmente no opera.
            await Task.CompletedTask;
            return false;
        }
    }
}