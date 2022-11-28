using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaTriangulo : Controller
    {
        [HttpGet]
        public IActionResult areaTriangulo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaTriangulo(double Base, double altura)
        {
            double resultado;
            string log;

            log = Base + " * " + altura + " / 2" + "\n";
            log = " " + (Base * altura) + " / 2" + "\n";

            resultado = Base * altura / 2;

            log += " " + resultado + " cm²";

            ViewBag.resultado = log;

            return View("areaTriangulo");
        }
    }
}
