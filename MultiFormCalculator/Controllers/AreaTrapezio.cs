using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class AreaTrapezio : Controller
    {
        [HttpGet]
        public IActionResult areaTrapezio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult areaTrapezio(double baseMenor, double baseMaior, double altura)
        {
            double resultado;
            string log;

            log = "(" + baseMenor + " + " + baseMaior + ")" + " * " + altura + " * 1 / 2" + "\n"; 
            log += " " + (baseMenor + baseMaior) + " * " + altura + " * 1 / 2" + "\n"; 
            log += " " + (baseMenor + baseMaior) * altura + " * 1 / 2" + "\n"; 

            resultado = (baseMenor + baseMaior) * altura / 2;

            log += " " + resultado + " cm²";

            ViewBag.resultado = log;

            return View("areaTrapezio");
        }
    }
}
