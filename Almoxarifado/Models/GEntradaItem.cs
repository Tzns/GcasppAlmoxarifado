using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GEntradaItem
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public virtual GEntrada GEntrada { get; set; }

        [Required]
        public virtual GProduto GProduto { get; set; }

        [Required(ErrorMessage = "Insira a quantidade.")]
        public long Quantidade { get; set; }

        [Required(ErrorMessage = "Insira o valor total.")]
        public decimal ValorTotal { get; set; }

        [Required]
        public decimal PrecoMedio { get; set; }

    }
}
