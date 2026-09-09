namespace EnlaceMVC.Models
{
    public class SobreViewModel
    {
        public string NomeEmpresa { get; set; } = string.Empty;
        public string MenuSobre { get; set; } = string.Empty;
        public string MenuServicos { get; set; } = string.Empty;
        public string MenuDepoimentos { get; set; } = string.Empty;
        public string BotaoOrcamento { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
        public string ImagemHero { get; set; } = string.Empty;
        public List<string> Imagens { get; set; } = new();
    }
}
