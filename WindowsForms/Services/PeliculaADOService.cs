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

        public async Task<List<Pais>?> GetAllAsync()
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand("SELECT * FROM peliculas", connection);
                var reader = await command.ExecuteReaderAsync();
                List<Pais> peliculas = new List<Pais>();
                while (await reader.ReadAsync())
                {
                    Pais pelicula = new Pais
                    {
                        id = Convert.ToInt32(reader["id"]),
                        titulo = reader["titulo"].ToString(),
                        duracion = Convert.ToInt32(reader["duracion"]),
                        portada = reader["portada"].ToString(),
                        calificacion = Convert.ToDouble(reader["calificacion"])
                    };
                    peliculas.Add(pelicula);
                }
                return peliculas;
            }
        }

        public async Task<bool> DeleteAsync(int? id)
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand($"DELETE FROM peliculas WHERE id={id}", connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    return true; // Se eliminó al menos una fila
                }
                else
                {
                    return false; // No se encontró la película o no se eliminó ninguna fila
                }
            }
        }
    
        public async Task<bool> UpdateAsync(Pais pelicula)
        {
            return false;
        }

        public async Task<bool> AddAsync(Pais pelicula)
        {
            return false;
        }
    }
}
