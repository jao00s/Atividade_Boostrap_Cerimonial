namespace EnlaceMVC.Models
{
    public class DepoimentosViewModel
    {
        public string NomeEmpresa { get; set; } = "";
        public string MenuSobre { get; set; } = "";
        public string MenuServicos { get; set; } = "";
        public string MenuDepoimentos { get; set; } = "";
        public string BotaoOrcamento { get; set; } = "";
        public string Titulo { get; set; } = "";
        public List<DepoimentoItem> Depoimentos { get; set; } = new();
    }

    public class DepoimentoItem
    {
        public string Nome { get; set; } = "";
        public string Texto { get; set; } = "";
        public string Imagem { get; set; } = "";
        public string Cor { get; set; } = "#8f008d";
    }
}
