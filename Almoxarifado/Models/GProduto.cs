using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GProduto
    {

        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira uma unidade.")]
        public int GPrudutoUnidadeId { get; set; }
        public GProdutoUnidade GPrudutoUnidade { get; set; }

        [Required(ErrorMessage = "Insira um codigo ainda não utilizado.")]       
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Insira uma descrição ainda não utilizado.")]        
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Range(100000000, 999999999, ErrorMessage = "Conta contábil inválida.")]
        public long? ContaContabil { get; set; }

        public long? CAEDespesa { get; set; }
    }
}
