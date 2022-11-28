using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaRetangulo : Controller
    {
        [HttpGet]
        public IActionResult areaRetangulo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaRetangulo(double Base, double altura)
        {
            double resultado;
            string log;

            log = Base + " * " + altura + "\n";

            resultado = Base * altura;

            log += " " + resultado + " cm²";

            ViewBag.resultado = log;

            return View("areaRetangulo");
        }
    }
}
