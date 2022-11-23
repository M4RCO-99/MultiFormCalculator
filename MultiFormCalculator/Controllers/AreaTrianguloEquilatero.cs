using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaTrianguloEquilatero : Controller
    {
        [HttpGet]
        public IActionResult areaTrianguloEquilatero()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaTrianguloEquilatero(double lado)
        {
            double resultado;
            string log;

            log = "3" + " * " + lado + " * " + lado + " / 4" + "\n";
            log += " " + "3" + " * " + (lado * lado) + " / 4" + "\n";
            log += " " + (3 * (lado * lado)) + " / 4" + "\n";

            resultado = 3 * (lado * lado) / 4;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("areaTrianguloEquilatero");
        }
    }
}
