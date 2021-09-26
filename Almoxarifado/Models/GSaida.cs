using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GSaida
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira uma data.")]
        [Column(TypeName = "smalldatetime")]
        public DateTime Data { get; set; }

        [Required]
        public List<GSaidaItem> GSaidaItem { get; set; }
    }
}
