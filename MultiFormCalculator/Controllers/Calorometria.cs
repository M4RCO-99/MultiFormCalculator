using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Calorometria : Controller
    {
        [HttpGet]
        public IActionResult calorometria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult calorometria(double aceleracao, double massa)
        {
            double resultado;
            string log;

            log = massa + " * " + aceleracao + "\n";

            resultado = massa * aceleracao;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("calorometria");
        }
    }
}
