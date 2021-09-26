using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GSaidaItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int GSaidaId { get; set; }
        public GSaida GSaida { get; set; }

        [Required]
        public int GProdutoId { get; set; }
        public GProduto GProduto { get; set; }

        [Required(ErrorMessage = "Insira a quantidade.")]
        public long Quantidade { get; set; }

        [Required(ErrorMessage = "Insira o valor total.")]
        public decimal ValorTotal { get; set; }

        [Required]
        public decimal PrecoMedio { get; set; }

    }
}

