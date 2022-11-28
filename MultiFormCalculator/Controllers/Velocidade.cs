using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Velocidade : Controller
    {
        [HttpGet]
        public IActionResult velocidade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult velocidade(double deslocamento, double tempo)
        {
            double resultado;
            string log;

            log = deslocamento + " / " + tempo + "\n";

            resultado = deslocamento / tempo;

            log += " " + resultado + " km/h";

            ViewBag.resultado = log;

            return View("velocidade");
        }
    }
}
