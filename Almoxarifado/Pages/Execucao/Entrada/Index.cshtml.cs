using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almoxarifado.Models;
using Almoxarifado.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Almoxarifado.Pages.Execucao.Entrada
{
    public class IndexModel : PageModel

    {
        private readonly IGEntradaRepository _repository;
        public IndexModel(IGEntradaRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<GEntrada> gEntrada;

        [BindProperty(SupportsGet = true)]
        public string Pesquisar { get; set; }

        public void OnGet()
        {
            gEntrada = _repository.Search(Pesquisar);
        }
    }
}
