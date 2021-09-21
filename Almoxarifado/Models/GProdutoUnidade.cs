using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GProdutoUnidade
    {
        
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira uma sigla.")]
        [MaxLength(5)]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "Insira uma descrição.")]
        [MaxLength(100)]
        public string Descricao { get; set; }
    }
}
