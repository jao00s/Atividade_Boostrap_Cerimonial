using EnlaceMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnlaceMVC.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Servicos()
        {
            var model = new ServicosViewModel
            {
                NomeEmpresa = "Enlace",
                MenuSobre = "Sobre nós",
                MenuServicos = "Serviços",
                MenuDepoimentos = "Depoimentos",

                Titulo = "Serviços",

                BotaoOrcamento = "Solicitar orçamento",

                Texto = "Na Enlace Cerimonial, transformamos momentos únicos em memórias inesquecíveis. Nosso trabalho vai muito além da condução de uma cerimônia: cuidamos de cada detalhe para que sua celebração reflita, de forma autêntica, a história e a essência de quem você é."
            };

            return View("~/Views/Home/Servicos.cshtml", model);
        }
    }
}