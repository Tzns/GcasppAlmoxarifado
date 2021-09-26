using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almoxarifado.Models;

namespace Almoxarifado.Repositories
{
    public interface IGProdutoRepository : IGenericRepository<GProduto>
    {

        IEnumerable<GProduto> Search(string pesquisar);

        IEnumerable<GProdutoUnidade> GetUnidade();
    }
        
}
