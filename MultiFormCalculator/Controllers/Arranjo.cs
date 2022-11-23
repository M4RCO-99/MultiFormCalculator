using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Arranjo : Controller
    {
        [HttpGet]
        public IActionResult arranjo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult arranjo(double n, double p)
        {
            double resultado;
            string log;

            if (n < p)
            {
                ViewBag.resultado = "n deve ser maior que p";

                return View("arranjo");
            }

            log = n + "!" + " / " + "(" + n + " - " + p + ")!" + "\n";
            log += " " + fatoracao(n, n) + " / " + "(" + n + " - " + p + ")!" + "\n";
            log += " " + fatoracao(n, n) + " / " + fatoracao(n - p, n - p) + "\n";

            resultado = fatoracao(n, n) / fatoracao(n - p, n - p);

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("arranjo");
        }

        static double fatoracao(double i, double n)
        {
            while (i != 0)
            {
                n *= i;

                i -= 1;
            }

            return n;
        }
    }
}
