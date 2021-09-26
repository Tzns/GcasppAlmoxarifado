using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almoxarifado.Models;
using Almoxarifado.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Almoxarifado.Pages.Execucao.Saida
{
    public class IndexModel : PageModel
    {

        private readonly IGSaidaRepository _repository;
        public IndexModel(IGSaidaRepository repository)
        {
            _repository = repository;
        }

        public  void OnGet()
        {
          
        }
    }
}

