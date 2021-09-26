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

namespace Almoxarifado.Pages.Cadastros.Produto
{
    public class EditModel : PageModel
    {
        private readonly IGProdutoRepository _repository;
        public EditModel(IGProdutoRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public GProduto GProduto { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            GProduto = await _repository.GetById(id);
            var unidadeLista = _repository.GetUnidade().ToList();

            ViewData["GPrudutoUnidadeId"] = new SelectList(unidadeLista, "Id", "Descricao");

            if (GProduto == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.UpdateAsync(GProduto);
                    return RedirectToPage("./Index");
                }
                catch (Exception)
                {
                    return RedirectToPage("./error");

                }
            }
            else
                return Page();
        }
    }
}
