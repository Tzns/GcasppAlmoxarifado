using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Almoxarifado.Models;
using Almoxarifado.Repositories;

namespace Almoxarifado.Pages.Fornecedor
{
    public class EditModel : PageModel
    {
        private readonly Almoxarifado.Repositories.DataContext _context;

        public EditModel(Almoxarifado.Repositories.DataContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GFornecedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GFornecedorExists(GFornecedor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GFornecedorExists(int id)
        {
            return _context.GFornecedor.Any(e => e.Id == id);
        }
    }
}
