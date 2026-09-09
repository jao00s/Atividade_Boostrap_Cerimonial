namespace AtividadeBootstrap.Models
{
    public class ServicoDestaque
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        // Cor do círculo e do título do card (código hexadecimal)
        public string Cor { get; set; } = "#000000";
    }
}
