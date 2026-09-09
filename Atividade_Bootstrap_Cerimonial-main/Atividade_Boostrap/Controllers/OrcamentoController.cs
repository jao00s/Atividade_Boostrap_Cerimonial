using AtividadeBootstrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeBootstrap.Controllers
{
    public class OrcamentoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(OrcamentoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ViewBag.Sucesso = "Solicitação de orçamento enviada com sucesso!";
            ModelState.Clear();
            return View();
        }
    }
}
