using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Almoxarifado.Models;
using Almoxarifado.Repositories;

namespace Almoxarifado.Pages.Fornecedor
{
    public class IndexModel : PageModel
    {
        private readonly Almoxarifado.Repositories.DataContext _context;

        public IndexModel(Almoxarifado.Repositories.DataContext context)
        {
            _context = context;
        }

        public IList<GFornecedor> GFornecedor { get;set; }

        public async Task OnGetAsync()
        {
            GFornecedor = await _context.GFornecedor.ToListAsync();
        }
    }
}
