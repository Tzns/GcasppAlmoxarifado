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

namespace Almoxarifado.Pages.Cadastros.Produto
{
    public class CreateModel : PageModel
    {
        private readonly IGProdutoRepository _repository;
        private readonly IGEstoqueRepository _eRepository;


        public CreateModel(IGProdutoRepository repository, IGEstoqueRepository estoqueRepository)
        {
            _repository = repository;
            _eRepository = estoqueRepository;
        }

        public IActionResult OnGet()
        {
            var unidadeLista = _repository.GetUnidade().ToList();

            ViewData["GPrudutoUnidadeId"] = new SelectList(unidadeLista, "Id", "Descricao");
            return Page();
            
        }

        [BindProperty]
        public GProduto GProduto { get; set; }
        

        public IList<GProdutoUnidade> GprodutoUnidade;
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                await _repository.CreateAsync(GProduto);

                GEstoque estoque = new GEstoque(GProduto.Id, 0, 0, 0);

                await _eRepository.CreateAsync(estoque);

                return RedirectToPage("./Index");
            }
            catch (Exception)
            {
                return RedirectToPage("./error"); //Para melhorar: Estudar AJAX para implantar na mesma pagina, sem perder os dados

            }
        }
    }
}
