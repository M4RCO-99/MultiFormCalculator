using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Trabalho : Controller
    {
        [HttpGet]
        public IActionResult trabalho()
        {
            return View();
        }

        [HttpPost]
        public IActionResult trabalho(double forca, double deslocamento)
        {
            double resultado;
            string log;

            log = forca + " * " + deslocamento + "\n";

            resultado = forca * deslocamento;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("trabalho");
        }
    }
}
