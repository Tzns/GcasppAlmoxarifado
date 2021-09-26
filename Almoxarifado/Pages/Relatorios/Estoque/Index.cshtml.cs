using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Almoxarifado.Data;
using Almoxarifado.Models;

namespace Almoxarifado.Pages.Relatorios.Estoque
{
    public class IndexModel : PageModel
    {
        private readonly Almoxarifado.Data.DataContext _context;

        public IndexModel(Almoxarifado.Data.DataContext context)
        {
            _context = context;
        }

        public IList<GEstoque> GEstoque { get;set; }

        public async Task OnGetAsync()
        {
            GEstoque = await _context.GEstoque
                .Include(g => g.GProduto).ToListAsync();
        }
    }
}
