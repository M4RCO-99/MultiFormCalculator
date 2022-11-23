using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class JurosComposto : Controller
    {
        [HttpGet]
        public IActionResult jurosComposto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult jurosComposto(double C, double i, double t)
        {
            double resultado;
            string log;

            log = C + " * " + "(" + 1 + " + " + i + ")" + " * " + t + "\n";
            log += " " + C + " * " + "(" + 1 + " + " + i + ")" + " * " + t + "\n";

            resultado = C * (1 + i) * t;

            ViewBag.resultado = resultado;

            return View("jurosComposto");
        }
    }
}
