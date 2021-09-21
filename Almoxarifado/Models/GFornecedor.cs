using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Models
{
    public class GFornecedor
    {
        
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira o nome.")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira o CNPJ.")]
        [Range(0, 99999999999999, ErrorMessage = "CNPJ inválido.")]
        [DisplayFormat(DataFormatString = "{0: 00.000/0000.00}", ApplyFormatInEditMode = true)]
        [MaxLength(14)]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Insira o endereço.")]
        [MaxLength(150)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Insira o número.")]
        public string Numero { get; set; }

        [MaxLength(150)]
        public string Complemento { get; set; } = "";

        [Required(ErrorMessage = "Insira o bairro.")]
        [MaxLength(50)]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Insira a cidade.")]
        [MaxLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Insira o Estado.")]
        [MaxLength(2)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Insira o País.")]
        [MaxLength(50)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Insira o CEP.")]
        [Range(0, 999999999, ErrorMessage = "CEP inválido.")]
        [DisplayFormat(DataFormatString = "{0: 00.000-000}", ApplyFormatInEditMode = true)]
        [MaxLength(9)]
        public string CEP { get; set; }
    }
}
