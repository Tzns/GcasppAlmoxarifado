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
    public class DetailsModel : PageModel
    {
        private readonly Almoxarifado.Repositories.DataContext _context;

        public DetailsModel(Almoxarifado.Repositories.DataContext context)
        {
            _context = context;
        }

        public GFornecedor GFornecedor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GFornecedor = await _context.GFornecedor.FirstOrDefaultAsync(m => m.Id == id);

            if (GFornecedor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
