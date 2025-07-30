using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;
using System.Net.Http.Json;
using WindowsForms.DataContext;
using Microsoft.EntityFrameworkCore;

namespace WindowsForms.Services
{
    public class PeliculaEFService
    {
        public async Task<List<Pais>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Peliculas.Include(p =>p.Pais).ToListAsync();
            }
        }

        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var peliculaABorrar = await cine.Peliculas.FindAsync(id);
                peliculaABorrar.Eliminado = true; // Marcamos como eliminado en lugar de borrar físicamente
                cine.Peliculas.Update(peliculaABorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al borrar la pelicula");
                }
            }
        }
    
        public async Task<bool> UpdateAsync(Pais peliculaActualizada)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Update(peliculaActualizada);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar la pelicula");
                }
            }
        }

        public async Task<bool> AddAsync(Pais peliculaAgregada)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Add(peliculaAgregada);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
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
