namespace AtividadeBootstrap.Models
{
    public class HomeViewModel
    {
        public string Titulo { get; set; } = "";
        public string Descricao { get; set; } = "";
        public string Botao { get; set; } = "";
        public List<Servico> Servicos { get; set; } = new();
    }

    public class Servico
    {
        public string Titulo { get; set; } = "";
        public string Descricao { get; set; } = "";
        public string Cor { get; set; } = "#cc2c08";
    }
}
