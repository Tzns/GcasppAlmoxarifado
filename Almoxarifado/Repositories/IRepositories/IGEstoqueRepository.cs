using Almoxarifado.Models;
using System.Collections.Generic;

namespace Almoxarifado.Repositories
{
    public interface IGEstoqueRepository : IGenericRepository<GEstoque>
    {
        IEnumerable<GEstoque> Search(string pesquisar);
    }
}