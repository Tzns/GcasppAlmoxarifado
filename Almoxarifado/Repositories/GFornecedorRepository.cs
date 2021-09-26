using Almoxarifado.Data;
using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GFornecedorRepository : GenericRepository<GFornecedor>, IGFornecedorRepository
    {
        public GFornecedorRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<GFornecedor> Search(string pesquisar)
        {
            if (string.IsNullOrEmpty(pesquisar))
            {
                return _context.GFornecedor.ToList();
            }
            return _context.GFornecedor.Where(t => t.Nome.Contains(pesquisar) ||
                                                   t.CNPJ.Contains(pesquisar));
        }
    }


}
