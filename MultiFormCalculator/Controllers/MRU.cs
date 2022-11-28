using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class MRU : Controller
    {
        [HttpGet]
        public IActionResult mru()
        {
            return View();
        }

        [HttpPost]
        public IActionResult mru(double espacoInicial, double velocidade, double tempo)
        {
            double resultado;
            string log;

            log = espacoInicial + " + " + velocidade + " * " + tempo + "\n";
            log += " " + espacoInicial + " + " + (velocidade * tempo) + "\n";

            resultado = espacoInicial + velocidade * tempo;

            log += " " + resultado + " km";

            ViewBag.resultado = log;

            return View("mru");
        }
    }
}
