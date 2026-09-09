using System.ComponentModel.DataAnnotations;

namespace AtividadeBootstrap.Models
{
    public class OrcamentoViewModel
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "Informe a data do evento.")]
        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Informe o telefone.")]
        public string Telefone { get; set; } = "";

        [Required(ErrorMessage = "Informe o endereço.")]
        public string Endereco { get; set; } = "";

        [Required(ErrorMessage = "Informe o CPF.")]
        public string CPF { get; set; } = "";
    }
}
