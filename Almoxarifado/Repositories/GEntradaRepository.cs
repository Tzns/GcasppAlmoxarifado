using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almoxarifado.Data;
using Almoxarifado.Models;

namespace Almoxarifado.Repositories
{
    public class GEntradaRepository : GenericRepository<GEntrada>, IGEntradaRepository
    {
        public GEntradaRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<GEntrada> Search(string pesquisar)
        {
            {
                if (string.IsNullOrEmpty(pesquisar))
                {
                    return _context.GEntrada.ToList();
                }
                return _context.GEntrada.Where(t => t.GFornecedorId.Equals(pesquisar) ||
                                                        t.Documento.Equals(pesquisar) ||
                                                             t.Data.Equals(pesquisar) ||
                                                                 t.Empenho.Equals(pesquisar));
            }
        }
    }
}

