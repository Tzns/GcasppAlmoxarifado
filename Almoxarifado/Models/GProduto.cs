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
        public virtual GProdutoUnidade GPrudutoUnidade { get; set; }

        [Required(ErrorMessage = "Insira um codigo.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Insira uma descrição.")]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Insira uma conta contábil.")]
        [Range(100000000, 999999999, ErrorMessage = "Conta contábil inválida.")]
        [DisplayFormat(DataFormatString = "{0: 0.0.0.0.0.00.00}", ApplyFormatInEditMode = true)]
        public long? ContaContabil { get; set; }
             
        public long? CAEDespesa { get; set; }
    }
}
