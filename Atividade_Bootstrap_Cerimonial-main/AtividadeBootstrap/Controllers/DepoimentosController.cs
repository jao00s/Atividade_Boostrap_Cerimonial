using EnlaceMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnlaceMVC.Controllers
{
    public class DepoimentosController : Controller
    {
        public IActionResult Depoimentos()
        {
            var model = new DepoimentosViewModel
            {
                NomeEmpresa = "Enlace",
                MenuSobre = "Sobre",
                MenuServicos = "Serviços",
                MenuDepoimentos = "Depoimentos",
                BotaoOrcamento = "Solicitar orçamento",
                Titulo = "Depoimentos",

                Depoimentos = new List<DepoimentoItem>
                {
                    new DepoimentoItem
                    {
                        Nome = "Juniper e Luciana",
                        Texto = "Equipe excelente e prestativa",
                        Imagem = "~/img/depoimentos/depoimento1.jpg",
                        Cor = "#8f008d"
                    },

                    new DepoimentoItem
                    {
                        Nome = "Tatiana e Luiz",
                        Texto = "Equipe excelente e prestativa",
                        Imagem = "~/img/depoimentos/depoimento2.jpg",
                        Cor = "#8f008d"
                    },

                    new DepoimentoItem
                    {
                        Nome = "Roberto e Claudia",
                        Texto = "Equipe excelente e prestativa",
                        Imagem = "~/img/depoimentos/depoimento3.jpg",
                        Cor = "#b5b900"
                    },

                    new DepoimentoItem
                    {
                        Nome = "Silvia e Antonio",
                        Texto = "Equipe excelente e prestativa",
                        Imagem = "~/img/depoimentos/depoimento4.jpg",
                        Cor = "#d7171f"
                    }
                }
            };

            return View("~/Views/Home/Depoimentos.cshtml", model);
        }
    }
}