using Almoxarifado.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DataContext _context;
        protected DbSet<T> table;

        public GenericRepository(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }


        public async Task Delete(int Id)
        {
            T objeto = await table.FindAsync(Id);

            if (objeto == null)
            {
                throw new NullReferenceException(($"{objeto} não foi encontrado."));
            }
            else
            {
                table.Remove(objeto);
                await SaveAsync();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await table.FindAsync(Id);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            table.Add(obj);
            await SaveAsync();
        }


        public async Task UpdateAsync(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Attach(obj).State = EntityState.Modified;
            await SaveAsync();
        }

    }
}

