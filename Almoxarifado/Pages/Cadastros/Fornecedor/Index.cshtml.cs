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

namespace Almoxarifado.Pages.Cadastros.Fornecedor
{
    public class IndexModel : PageModel

    {
        private readonly IGFornecedorRepository _repository;        
        public IndexModel(IGFornecedorRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<GFornecedor> gFornecedor;
               
        [BindProperty(SupportsGet = true)]
        public string Pesquisar { get; set; }
        
        public void OnGet()
        {
            gFornecedor = _repository.Search(Pesquisar);
        }
    }    
}
