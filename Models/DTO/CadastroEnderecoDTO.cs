using System.ComponentModel.DataAnnotations;

namespace apiAutenticacao.Models.DTO
{
    public class CadastroEnderecoDTO
    {
        [Required(ErrorMessage = "O CEP é obrigatório")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve conter exatamente 8 caracteres")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório")]
        [StringLength(200, ErrorMessage = "O Logradouro deve ter no máximo 200 caracteres")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Número é obrigatório")]
        [StringLength(10, ErrorMessage = "O Número deve ter no máximo 10 caracteres")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O Complemento é obrigatório")]
        [StringLength(100, ErrorMessage = "O complemento deve ter no máximo 100 caracteres")]
        public string Complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Cidade é obrigatória")]
        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Estado é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O Estado deve conter exatamente 2 caracteres")] 
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "O País é obrigatório")]
        [StringLength(100, ErrorMessage = "O País deve ter no máximo 100 caracteres")]
        public string Pais { get; set; } = string.Empty;




    }
}
