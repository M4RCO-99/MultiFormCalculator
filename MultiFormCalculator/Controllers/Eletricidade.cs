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

            log = resistenciaEletrica + " * " + intensidadeCorrente + " * " + "10^-3" + "\n";
            log += " " + resistenciaEletrica * intensidadeCorrente + " * " + "10^-3" + "\n";

            resultado = resistenciaEletrica * intensidadeCorrente;
            resultado /= 1000;

            log += " " + resultado + " V";

            ViewBag.resultado = log;

            return View("eletricidade");
        }
    }
}
