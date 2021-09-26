using Almoxarifado.Data;
using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GEstoqueRepository : GenericRepository<GEstoque>, IGEstoqueRepository
    {
        public GEstoqueRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<GEstoque> Search(string pesquisar)
        {
            if (string.IsNullOrEmpty(pesquisar))
            {
                return _context.GEstoque.ToList();
            }
            return _context.GEstoque.Where(t => t.GProduto.Descricao.Contains(pesquisar) ||
                                                   t.Quantidade.Equals(pesquisar));
        }
    }
}
