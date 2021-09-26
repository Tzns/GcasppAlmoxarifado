using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Almoxarifado.Data;
using Almoxarifado.Models;

namespace Almoxarifado.Pages.Execucao.Entrada
{
    public class CreateModel : PageModel
    {
        private readonly Almoxarifado.Data.DataContext _context;

        public CreateModel(Almoxarifado.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GFornecedorId"] = new SelectList(_context.GFornecedor, "Id", "Bairro");
            return Page();
        }

        [BindProperty]
        public GEntrada GEntrada { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GEntrada.Add(GEntrada);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
