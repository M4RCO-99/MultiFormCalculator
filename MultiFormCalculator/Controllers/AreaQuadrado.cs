using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaQuadrado : Controller
    {
        [HttpGet]
        public IActionResult areaQuadrado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaQuadrado(double lado)
        {
            double resultado;
            string log;

            log = lado + " * " + lado + "\n";

            resultado = lado * lado;

            log += " " + resultado + " cm²";

            ViewBag.resultado = log;

            return View("areaQuadrado");
        }
    }
}
