using Almoxarifado.Data;
using Almoxarifado.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almoxarifado.Pages.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;

namespace Almoxarifado.Repositories
{
    public class GProdutoRepository : GenericRepository<GProduto>, IGProdutoRepository
    {
        protected DbSet<GEstoque> estoqueRepository;


        public GProdutoRepository(DataContext context) : base(context)
        {
            estoqueRepository = _context.Set<GEstoque>();
        }

        public IEnumerable<GProduto> Search(string pesquisar)
        {
            if (string.IsNullOrEmpty(pesquisar))
            {
                return _context.GProduto.ToList();
            }
            return _context.GProduto.Where(t => t.Codigo.Equals(pesquisar) ||
                                                   t.Descricao.Contains(pesquisar));

        }

        IEnumerable<GProdutoUnidade> IGProdutoRepository.GetUnidade()
        {
            return _context.GProdutoUnidade.ToList();
        }

        public void Check(int codigo)
        {
            if (_context.GProduto.Any(t => t.Codigo.Equals(codigo)))
            {
             throw new ArgumentException("ESTE CODIGO JA EXISTE");
            }
            

        }
    }
}

