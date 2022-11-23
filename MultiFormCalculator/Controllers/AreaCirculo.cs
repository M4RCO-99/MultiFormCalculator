using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaCirculo : Controller
    {
        [HttpGet]
        public IActionResult areaCirculo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaCirculo(double raio)
        {
            double resultado;
            string log;

            log = "3,14 * " + raio + "\n";

            resultado = 3.14 * raio;

            log += " " + resultado; 

            ViewBag.resultado = log;

            return View("areaCirculo");
        }
    }
}
