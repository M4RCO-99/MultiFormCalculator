using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class MRUV : Controller
    {
        [HttpGet]
        public IActionResult mruv()
        {
            return View();
        }

        [HttpPost]
        public IActionResult mruv(double velocidadeInicial, double intervaloTempo, double aceleracao)
        {
            double resultado;
            string log;

            log = velocidadeInicial + " * " + intervaloTempo + " + " + 1 + " / " + 2 + " * " + aceleracao + " * " + intervaloTempo + " * " + intervaloTempo + "\n"; 
            log += " " + velocidadeInicial + " * " + intervaloTempo + " + " + 1 + " / " + 2 + " * " + aceleracao + " * " + (intervaloTempo * intervaloTempo) + "\n"; 
            log += " " + (velocidadeInicial * intervaloTempo) + " + " + 1 + " / " + 2 + " * " + aceleracao + " * " + (intervaloTempo * intervaloTempo) + "\n"; 
            log += " " + (velocidadeInicial * intervaloTempo) + " + " + 1 + " / " + 2 + " * " + (aceleracao  * (intervaloTempo * intervaloTempo)) + "\n"; 
            log += " " + (velocidadeInicial * intervaloTempo) + " + " + (aceleracao * (intervaloTempo * intervaloTempo)) + " / " + 2 + "\n"; 
            log += " " + (velocidadeInicial * intervaloTempo) + " + " + ((aceleracao * (intervaloTempo * intervaloTempo)) / 2) + "\n"; 

            resultado = ((velocidadeInicial * intervaloTempo) + ((aceleracao * (intervaloTempo * intervaloTempo)) / 2));

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("mruv");
        }
    }
}
