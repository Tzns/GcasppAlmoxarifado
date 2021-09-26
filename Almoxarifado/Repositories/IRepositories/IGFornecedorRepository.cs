using Almoxarifado.Models;
using System.Collections.Generic;

namespace Almoxarifado.Repositories
{
    public interface IGFornecedorRepository : IGenericRepository<GFornecedor>
    {
        IEnumerable<GFornecedor> Search(string pesquisar);
    }
}