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
        public IActionResult calorometria(double massa, double calor, double temperatura)
        {
            double resultado;
            string log;

            log = massa + " * " + calor + " * " + temperatura + "\n";
            log += " " + (massa * calor) + " * " + temperatura + "\n";

            resultado = massa * calor + temperatura;

            log += " " + resultado + " cal";

            ViewBag.resultado = log;

            return View("calorometria");
        }
    }
}
