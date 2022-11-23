using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class TeoremaPitagoras : Controller
    {
        [HttpGet]
        public IActionResult teoremaPitagoras()
        {
            return View();
        }

        [HttpPost]
        public IActionResult teoremaPitagoras(double cateto1, double cateto2)
        {
            double resultado;
            string log;

            log = "Raiz quadrada de " + "(" + cateto1 + " * " + cateto1 + ")" + " + " + "(" + cateto2 + " * " + cateto2 + ")" + "\n";
            log += " " + "Raiz quadrada de " + cateto1 * cateto1 + " + " + "(" + cateto2 + " * " + cateto2 + ")" + "\n";
            log += " " + "Raiz quadrada de " + cateto1 * cateto1 + " + " + cateto2 * cateto2 + "\n";

            resultado = cateto1 * cateto1 + cateto2 * cateto2;

            log += " " + "Raiz quadrada de " + resultado + "\n";

            resultado = Math.Sqrt(resultado);

            log += " " + resultado;


            ViewBag.resultado = log;

            return View("teoremaPitagoras");
        }
    }
}
