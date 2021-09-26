using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Almoxarifado.Data;
using Almoxarifado.Models;
using Almoxarifado.Repositories;

namespace Almoxarifado.Pages.Cadastros.ProdutoUnidade
{
    public class DeleteModel : PageModel
    {
        private readonly IGProdutoUnidadeRepository _repository;


        public DeleteModel(IGProdutoUnidadeRepository reposiory)
        {
            _repository = reposiory;
        }

        [BindProperty]
        public GProdutoUnidade GProdutoUnidade { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            GProdutoUnidade = await _repository.GetById(id);

            if (GProdutoUnidade == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            await _repository.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}
