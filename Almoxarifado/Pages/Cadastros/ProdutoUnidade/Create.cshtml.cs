using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Almoxarifado.Data;
using Almoxarifado.Models;
using Almoxarifado.Repositories;

namespace Almoxarifado.Pages.Cadastros.ProdutoUnidade
{
    public class CreateModel : PageModel
    {
        private readonly IGProdutoUnidadeRepository _repository;

        public CreateModel(IGProdutoUnidadeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GProdutoUnidade GProdutoUnidade { get; set; }
              
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _repository.CreateAsync(GProdutoUnidade);           
           

            return RedirectToPage("./Index");
        }
    }
}
