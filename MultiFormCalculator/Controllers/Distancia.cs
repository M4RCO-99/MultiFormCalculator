using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Distancia : Controller
    {
        [HttpGet]
        public IActionResult distancia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult distancia(double velocidade, double tempo)
        {
            double resultado;
            string log;

            log = velocidade + " * " + tempo + "\n";

            resultado = velocidade * tempo;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("distancia");
        }
    }
}
