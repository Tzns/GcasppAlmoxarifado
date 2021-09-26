using System.Collections.Generic;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public interface IGenericRepository<T> where T : class

    {



        Task UpdateAsync(T obj);
        Task Delete(int Id);
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T obj);
        Task SaveAsync();
        Task<T> GetById(int id);
    }
}