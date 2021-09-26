using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GEntrada
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira uma data.")]
        [Column(TypeName = "smalldatetime")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Insira um fornecedor.")]
        public int GFornecedorId { get; set; }
        public GFornecedor GFornecedor { get; set; }

        [Required(ErrorMessage = "Insira um documento")]
        public string Documento { get; set; }

        public string Empenho { get; set; } = "";

        [Required]
        public  List<GEntradaItem> GEntradaItem { get; set; }
    }
}
