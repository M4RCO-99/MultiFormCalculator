using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class NumeroMols : Controller
    {
        [HttpGet]
        public IActionResult numeroMols()
        {
            return View();
        }

        [HttpPost]
        public IActionResult numeroMols(double massa, double massaMolar)
        {
            double resultado;
            string log;

            log = massa + " / " + massaMolar + "\n";

            resultado = massa / massaMolar;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("numeroMols");
        }
    }
}
