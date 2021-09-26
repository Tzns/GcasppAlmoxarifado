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
    public class IndexModel : PageModel

    {
        private readonly IGProdutoUnidadeRepository _repository;        
        public IndexModel(IGProdutoUnidadeRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<GProdutoUnidade> gProdutoUnidade;
               
        [BindProperty(SupportsGet = true)]
        public string Pesquisar { get; set; }
        
        public void OnGet()
        {
          gProdutoUnidade = _repository.Search(Pesquisar);
        }
    }    
}
