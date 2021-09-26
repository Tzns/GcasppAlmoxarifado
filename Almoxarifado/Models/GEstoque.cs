using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GEstoque
    {
        public GEstoque(int id, long quantidade, decimal valorTotal, decimal precoMedio)
        {            
            Id = id;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            PrecoMedio = precoMedio;
        }

        [Required]
        public int Id { get; set; }
        public  GProduto GProduto { get; set; }

        [Required]
        public long Quantidade { get; set; }

        [Required]
        public decimal ValorTotal { get; set; }

        [Required]
        public decimal PrecoMedio { get; set; }

        
       

    }
}
