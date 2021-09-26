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
    public class DetailsModel : PageModel
    {
        private readonly IGFornecedorRepository _repository;

        public DetailsModel(IGFornecedorRepository repository)
        {
            _repository = repository;
        }

        public GFornecedor GFornecedor { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            GFornecedor = await _repository.GetById(id);
            if (GFornecedor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
