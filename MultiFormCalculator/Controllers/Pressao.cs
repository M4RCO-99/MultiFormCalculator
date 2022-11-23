using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Pressao : Controller
    {
        [HttpGet]
        public IActionResult pressao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult pressao(double forca, double area)
        {
            double resultado;
            string log;

            log = forca + " / " + area + "\n";

            resultado = forca / area;

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("pressao");
        }
    }
}
