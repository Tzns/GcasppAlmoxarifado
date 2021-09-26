using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Almoxarifado.Data;
using Almoxarifado.Models;
using Almoxarifado.Repositories;

namespace Almoxarifado.Pages.Cadastros.Fornecedor
{
    public class EditModel : PageModel
    {
        private readonly IGFornecedorRepository _repository;
        public EditModel(IGFornecedorRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public GFornecedor GFornecedor { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            GFornecedor = await _repository.GetById(id);

            if (GFornecedor == null)
            {
                return NotFound();
            }
            return Page();
        }

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateAsync(GFornecedor);
                return RedirectToPage("./Index");
            }
            else
                return Page();
        }          
    }
}
