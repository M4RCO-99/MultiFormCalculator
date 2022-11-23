using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Eletricidade : Controller
    {
        [HttpGet]
        public IActionResult eletricidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult eletricidade(double resistenciaEletrica, double intensidadeCorrente)
        {
            double resultado;
            string log;

            log = resistenciaEletrica + " * " + intensidadeCorrente + "\n";

            resultado = resistenciaEletrica * intensidadeCorrente;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("eletricidade");
        }
    }
}
