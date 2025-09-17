using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class PeliculaService
    {
        string url = "https://netflisp-77fe.restdb.io/rest/peliculas?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";

        public async Task<List<Pelicula>?> GetAllAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Pelicula>>();
                }
                else
                {
                    throw new Exception("Error al obtener las peliculas");
                }
            }
        }
        public async Task<bool> DeleteAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://netflisp-77fe.restdb.io/rest/peliculas/{id}?apikey=5ef3666c6a76415a50ddab26a474d3a68c6b4";

                var response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar la pelicula");
                }
            }
        }
        public async Task<bool> UpdateAsync(Pelicula pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://netflisp-77fe.restdb.io/rest/peliculas/{pelicula._id}?apikey=5ef3666c6a76415a50ddab26a474d3a68c6b4";
                var response = await client.PutAsJsonAsync(url, pelicula);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar la pelicula");
                }
            }
        }
        public async Task<bool> AddAsync(Pelicula pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, pelicula);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar la pelicula");
                }
            }
        }
    }
}
