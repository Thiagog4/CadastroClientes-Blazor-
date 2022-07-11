using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CadastroClientesBlazorWASM.Models
{
    public class ContatosModel
    {

        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Celular { get; set; }

    }
}
