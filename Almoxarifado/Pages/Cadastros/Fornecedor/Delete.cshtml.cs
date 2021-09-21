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
    public class DeleteModel : PageModel
    {
        private readonly DataContext _context;

        public DeleteModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
                        
            GFornecedor = await _context.GFornecedor.FindAsync(id);
            

            if (GFornecedor != null)
            {
                _context.GFornecedor.Remove(GFornecedor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
