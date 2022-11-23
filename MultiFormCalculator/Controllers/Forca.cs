using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Forca : Controller
    {
        [HttpGet]
        public IActionResult forca()
        {
            return View();
        }

        [HttpPost]
        public IActionResult forca(double massa, double aceleracao)
        {
            double resultado;
            string log;

            log = massa + " * " + aceleracao + "\n";

            resultado = massa * aceleracao;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("forca");
        }
    }
}
