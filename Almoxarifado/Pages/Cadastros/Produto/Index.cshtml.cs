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
    public class IndexModel : PageModel
    {
        private readonly IGProdutoRepository _repository;
        public IndexModel(IGProdutoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<GProduto> gProduto;

        [BindProperty(SupportsGet = true)]
        public string Pesquisar { get; set; }

        public void OnGet()
        {
            gProduto = _repository.Search(Pesquisar);
        }
    }
}
