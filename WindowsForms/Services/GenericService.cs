using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using WindowsForms.DataContext;
using WindowsForms.Interfaces;

namespace WindowsForms.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        public async Task<T?> AddAsync(T? entity)
        {
            using (CineContext cine = new CineContext());
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
                }
                cine.Set<T>().Add(entity);
                var result = await cine.SaveChangesAsync();
                // si pudo guardar los cambios retornamos verdadero
                if (result > 0)
                {
                    return entity;
                }
                // si no pudo guardar los cambios retornamos nulo
                 

            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>?> GetAllAsync(string? filtro)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T? entity)
        {
            throw new NotImplementedException();
        }
    }
}
