using apiAutenticacao.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace apiAutenticacao.Models
{
    public class Endereco
    {
        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve conter exatamente 8 caracteres")]
        public int Cep { get; set; } 

        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        [StringLength(200, ErrorMessage = "O Logradouro deve ter no máximo 200 caracteres")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Número é obrigatório")]
        [StringLength(10, ErrorMessage = "O Número deve ter no máximo 10 caracteres")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo Complemento é obrigatório")]
        [StringLength(100, ErrorMessage = "O complemento deve ter no máximo 100 caracteres")]
        public string Complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O Estado deve conter exatamente 2 caracteres")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo País é obrigatório")]
        [StringLength(100, ErrorMessage = "O País deve ter no máximo 100 caracteres")]
        public string Pais { get; set; } = string.Empty;


















       







       
        
    }
}
