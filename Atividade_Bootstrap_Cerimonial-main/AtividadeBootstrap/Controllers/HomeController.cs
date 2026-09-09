using Microsoft.AspNetCore.Mvc;
using EnlaceHomeMVC.Models;

namespace EnlaceHomeMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Titulo = "Cerimonias que contam sua historia",
                Descricao = "Condução de cerimonias de casamento com acolhimento, elegancia e atenção a cada detalhe",
                Botao = "Solicitar orçamento",
                Servicos = new List<Servico>
                {
                    new Servico
                    {
                        Titulo = "Cerimonia Civil",
                        Descricao = "Roteiro personalizado para o casal",
                        Cor = "#cc2c08"
                    },
                    new Servico
                    {
                        Titulo = "Mestre de Cerimonia",
                        Descricao = "Condução para o grande dia",
                        Cor = "#8e0085"
                    },
                    new Servico
                    {
                        Titulo = "Acessoria de Roteiro",
                        Descricao = "Ensaio e apoio no dia da cerimonia",
                        Cor = "#e73bbd"
                    }
                }
            };

            return View(model);
        }
    }
}
