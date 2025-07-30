using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;
using System.Net.Http.Json;

namespace WindowsForms.Services
{
    public class PeliculaService
    {
        string url = "https://netflisp-77fe.restdb.io/rest/peliculas?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";

        public async Task<List<Pais>?> GetAllAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Pais>>();
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
                string url = $"https://netflisp-77fe.restdb.io/rest/peliculas/{id}?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";
                var response = await client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception ("Error al eliminar la pelicula");
                }
            }
        }
    
        public async Task<bool> UpdateAsync(Pais pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://netflisp-77fe.restdb.io/rest/peliculas/{pelicula._id}?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";
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

        public async Task<bool> AddAsync(Pais pelicula)
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
                    throw new Exception("Error al crear la pelicula");
                }
            }
        }
    }
}
