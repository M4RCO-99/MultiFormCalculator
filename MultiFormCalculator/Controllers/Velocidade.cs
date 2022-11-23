using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Velocidade : Controller
    {
        [HttpGet]
        public IActionResult velocidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult velocidade(double velocidadeInicial, double aceleração, double intervaloTempo)
        {
            double resultado;
            string log;

            log = velocidadeInicial + " + " + aceleração + " * " + intervaloTempo + "\n";
            log += " " + velocidadeInicial + " + " + (aceleração * intervaloTempo) + "\n";

            resultado = velocidadeInicial + aceleração * intervaloTempo;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("velocidade");
        }
    }
}
