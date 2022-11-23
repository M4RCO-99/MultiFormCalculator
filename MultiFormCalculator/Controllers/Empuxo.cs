using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Empuxo : Controller
    {
        [HttpGet]
        public IActionResult empuxo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult empuxo(double densidade, double volumeDeslocado, double aceleraçãoGravidade)
        {
            double resultado;
            string log;

            log = densidade + " * " + volumeDeslocado + " * " + aceleraçãoGravidade + "\n";
            log += " " + (densidade * volumeDeslocado) + " * " + aceleraçãoGravidade + "\n";

            resultado = densidade * volumeDeslocado * aceleraçãoGravidade;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("empuxo");
        }
    }
}
