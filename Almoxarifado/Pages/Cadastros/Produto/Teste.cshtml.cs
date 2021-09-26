using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Almoxarifado.Data;
using Almoxarifado.Models;

namespace Almoxarifado.Pages.Cadastros.Produto
{
    public class TesteModel : PageModel
    {
        private readonly Almoxarifado.Data.DataContext _context;

        public TesteModel(Almoxarifado.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GPrudutoUnidadeId"] = new SelectList(_context.GProdutoUnidade, "Id", "Descricao");
            return Page();
        }

        [BindProperty]
        public GProduto GProduto { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GProduto.Add(GProduto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
