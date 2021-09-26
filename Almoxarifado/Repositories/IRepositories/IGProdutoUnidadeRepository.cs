using Almoxarifado.Models;
using System.Collections.Generic;

namespace Almoxarifado.Repositories
{
    public interface IGProdutoUnidadeRepository : IGenericRepository<GProdutoUnidade>
    {
        IEnumerable<GProdutoUnidade> Search(string pesquisar);
    }
}