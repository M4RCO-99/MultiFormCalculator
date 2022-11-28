using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaLosango : Controller
    {
        [HttpGet]
        public IActionResult areaLosango()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaLosango(double D, double d)
        {
            double resultado;
            string log;

            log = D + " * " + d + " / " + 2 + "\n";
            log += " " + D * d + " / " + 2 + "\n";

            resultado = D * d / 2;

            log += " " + resultado + " cm²";

            ViewBag.resultado = log;

            return View("areaLosango");
        }
    }
}
