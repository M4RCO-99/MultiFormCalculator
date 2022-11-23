using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class JurosSimples : Controller
    {
        [HttpGet]
        public IActionResult jurosSimples()
        {
            return View();
        }

        [HttpPost]
        public IActionResult jurosSimples(double C, double i, double t)
        {
            double resultado;
            string log;

            log = C + " * " + i + " * " + t + "\n";
            log += " " + (C * i) + " * " + t + "\n";

            resultado = C * i * t;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("jurosSimples");
        }
    }
}
