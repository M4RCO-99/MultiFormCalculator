using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class ConcentracaoMolar : Controller
    {
        [HttpGet]
        public IActionResult concentracaoMolar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult concentracaoMolar(double numeroMol, double volume)
        {
            double resultado;
            string log;

            log = numeroMol + " / " + volume + "\n";

            resultado = numeroMol / volume;

            log += " " + resultado + " mol/L";

            ViewBag.resultado = log;

            return View("concentracaoMolar");
        }
    }
}
