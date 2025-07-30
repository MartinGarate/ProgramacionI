using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class StockInventarioADOService
    {
        string connectionString = "server=127.0.0.1;user=root;password=;database=stockinventario";


        public async Task<List<StockInventarioADO>> GetStockItemsAsync()
        {
            //obtenemos con ado.net desde mi mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand("SELECT * FROM producto", connection);
                var reader = await command.ExecuteReaderAsync();
                List<StockInventarioADO> stockInventario = new List<StockInventarioADO>();
                while (await reader.ReadAsync())
                {
                    StockInventarioADO stockInventarioADO = new StockInventarioADO
                    {
                        _id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : (int?)null,
                        nombre = reader["nombre"].ToString(),
                        cantidad_stock = reader["cantidad_stock"] != DBNull.Value ? Convert.ToInt32(reader["cantidad_stock"]) : (int?)null,
                        precio = Convert.ToDouble(reader["precio"]),
                        proveedor = reader["proveedor"].ToString(),
                        url_imagen = reader["url_imagen"] != DBNull.Value ? reader["url_imagen"].ToString() : null
                    };
                   
                    stockInventario.Add(stockInventarioADO);
                }
                return stockInventario;
            }
            }

        public async Task<bool> DeleteAsync(int? _id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand($"DELETE FROM producto WHERE id={_id}", connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    return true;//se elimino correctamente
                }
                else
                {
                    return false;//no se encontro pelicula o se elimino
                }

            }


        }

        public async Task<bool> AddAsync(StockInventarioADO producto)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var query = $"INSERT INTO producto (nombre, cantidad_stock, precio, proveedor, url_imagen) VALUES" +
                    $"('{producto.nombre}'," +
                    $"{producto.cantidad_stock}," +
                    $"{producto.precio}," +
                    $"'{producto.proveedor}'," +
                    $"'{producto.url_imagen}')";


                var command = new MySqlCommand(query, connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    return true;//se actualizo correctamente
                }
                else
                {
                    return false;//no se completo el proceso.
                }
            }
        }

        public async Task<bool> UpdateAsync(StockInventarioADO producto)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var query = $"UPDATE producto SET " +
                    $"nombre='{producto.nombre}', " +
                    $"cantidad_stock={producto.cantidad_stock}, " +
                    $"precio={producto.precio}, " +
                    $"proveedor='{producto.proveedor}', " +
                    $"url_imagen='{producto.url_imagen}' " +
                    $"WHERE id={producto._id}";
                var command = new MySqlCommand(query, connection);
                var rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    return true;//se actualizo correctamente
                }
                else
                {
                    return false;//no se completo el proceso.
                }
            }
        }
    }
}
