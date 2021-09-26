using Almoxarifado.Data;
using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GProdutoUnidadeRepository : GenericRepository<GProdutoUnidade>, IGProdutoUnidadeRepository
    {
        public GProdutoUnidadeRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<GProdutoUnidade> Search(string pesquisar)
        {

            if (string.IsNullOrEmpty(pesquisar))
            {
                return _context.GProdutoUnidade.ToList();
            }
            return _context.GProdutoUnidade.Where(t => t.Sigla.Contains(pesquisar) ||
                                                   t.Descricao.Contains(pesquisar));

        }
    }
}
