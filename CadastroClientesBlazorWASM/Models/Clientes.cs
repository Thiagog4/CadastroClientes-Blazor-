using System.ComponentModel.DataAnnotations;

namespace CadastroClientesBlazorWASM.Models
{
    public class Clientes
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="CPF obrigatorio")]
        [StringLength(11, ErrorMessage ="Esse campo precisa ter 11 caracteres")]
        [MaxLength(11,ErrorMessage ="Esse campo pode no max 11 caracteres")]
        public string Cpf { get; set; }


        [Required(ErrorMessage = "Nome obrigatorio")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Celular obrigatorio")]
        [MaxLength(11, ErrorMessage = "Numero max de caracteres permitos 11")]
        public string Celular { get; set; }


        [Required(ErrorMessage = "CEP obrigatorio")]
        [MaxLength(11, ErrorMessage = "Numero max de caracteres permitos 9")]
        public string? Cep { get; set; }
        [Required(ErrorMessage = "Endereço obrigatorio")]
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string? EstadoCivil { get; set; }

    }
}
