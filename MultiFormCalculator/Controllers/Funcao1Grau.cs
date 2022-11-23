using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Funcao1Grau : Controller
    {
        [HttpGet]
        public IActionResult funcao1Grau()
        {
            return View();
        }

        [HttpPost]
        public IActionResult funcao1Grau(double a, double b, double x)
        {
            double resultado;
            string log;

            log = a + " * " + x + " + " + b + "\n";
            log += " " + (a * x) + " + " + b + "\n";

            resultado = a * x + b;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("funcao1Grau");
        }
    }
}
