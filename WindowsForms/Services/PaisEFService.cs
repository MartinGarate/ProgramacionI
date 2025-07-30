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
    public class PaisEFService
    {
        public async Task<List<Pais>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Paises.ToListAsync();
            }
        }

        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var PaisBorrar = await cine.Paises.FindAsync(id);
                PaisBorrar.Eliminado = true; // Marcamos como eliminado
                cine.Paises.Update(PaisBorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true; // Se eliminó correctamente
                }
                else
                {
                    throw new Exception("Error al eliminar el pais");
                }
            }

        }
    
        public async Task<bool> UpdateAsync(Pais pais)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Paises.Update(pais);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar el pais");
                }
            }
        }

        public async Task<bool> AddAsync(Pais pais)
        {
            using (CineContext cine = new CineContext())
            {
                cine.Paises.Add(pais);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el pais");
                }
            }
        }
    }
}
