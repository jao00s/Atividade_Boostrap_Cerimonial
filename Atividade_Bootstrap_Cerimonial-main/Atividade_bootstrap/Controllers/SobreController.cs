using EnlaceMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnlaceMVC.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Sobre()
        {
            var model = new SobreViewModel
            {
                NomeEmpresa = "Enlace",
                MenuSobre = "Sobre nós",
                MenuServicos = "Serviços",
                MenuDepoimentos = "Depoimentos",

                BotaoOrcamento = "Solicitar orçamento",

                Titulo = "Sobre",

                Texto = "A Enlace Cerimonial nasceu da paixão por transformar cerimônias em momentos únicos e inesquecíveis. Com sensibilidade, profissionalismo e atenção a cada detalhe, conduzimos seu grande dia com a mesma dedicação e elegância que ele merece.",

                ImagemHero = "https://images.unsplash.com/photo-1519167758481-83f550bb49b3?auto=format&fit=crop&w=1600&q=85",

                Imagens = new List<string>
                {
                    "https://images.unsplash.com/photo-1519741497674-611481863552?auto=format&fit=crop&w=800&q=85",
                    "https://images.unsplash.com/photo-1511578314322-379afb476865?auto=format&fit=crop&w=800&q=85",
                    "https://images.unsplash.com/photo-1519225421980-715cb0215aed?auto=format&fit=crop&w=800&q=85"
                }
            };

            return View("~/Views/Home/Sobre.cshtml", model);
        }
    }
}