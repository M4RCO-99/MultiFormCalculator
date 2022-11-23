using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Densidade : Controller
    {
        [HttpGet]
        public IActionResult densidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult densidade(double massa, double volume)
        {
            double resultado;
            string log;

            log = massa + " / " + volume + "\n";

            resultado = massa / volume;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("densidade");
        }
    }
}
