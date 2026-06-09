using Microsoft.AspNetCore.Mvc;
using Calculadora_IMC.Models;

namespace Calculadora_IMC.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Imc imc)
        {
            if (!ModelState.IsValid)
            {
                return View(imc);
            }

            double resultado = imc.Peso.Value / (imc.Altura.Value * imc.Altura.Value);

            ViewBag.Resultado = resultado;

            return View("Resultado", imc);
        }
    }
}