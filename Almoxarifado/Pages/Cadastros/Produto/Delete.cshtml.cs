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

namespace Almoxarifado.Pages.Cadastros.Produto
{
    public class DeleteModel : PageModel
    {
        private readonly IGProdutoRepository _repository;


        public DeleteModel(IGProdutoRepository reposiory)
        {
            _repository = reposiory;
        }

        [BindProperty]
        public GProduto GProduto { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            GProduto = await _repository.GetById(id);

            if (GProduto == null)
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
