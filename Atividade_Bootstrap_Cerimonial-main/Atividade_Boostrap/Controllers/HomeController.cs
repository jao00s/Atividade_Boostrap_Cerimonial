using AtividadeBootstrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Titulo = "Cerimônias que contam sua história",

                Descricao = "Condução de cerimônias de casamento com acolhimento, elegância e atenção a cada detalhe.",

                Botao = "Solicitar orçamento",

                Servicos = new List<Servico>
                {
                    new Servico
                    {
                        Titulo = "Cerimônia Civil",
                        Descricao = "Roteiro personalizado para o casal",
                        Cor = "#cc2c08"
                    },

                    new Servico
                    {
                        Titulo = "Mestre de Cerimônia",
                        Descricao = "Condução para o grande dia",
                        Cor = "#8e0085"
                    },

                    new Servico
                    {
                        Titulo = "Acessoria de Roteiro",
                        Descricao = "Ensaio e apoio no dia da cerimônia",
                        Cor = "#e72bbd"
                    }
                }
            };

            return View(model);
        }
    }
}