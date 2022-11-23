using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Permutacao : Controller
    {
        [HttpGet]
        public IActionResult permutacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult permutacao(double n, double p)
        {
            double resultado;
            string log;

            if (n < p)
            {
                ViewBag.resultado = "n deve ser maior que p";

                return View("arranjo");
            }

            log = n + "!" + " / " + p + "!" + "\n";
            log += fatoracao(n, n) + " / " + p + "!" + "\n";
            log += fatoracao(n, n) + " / " + fatoracao(p, p) + "\n";

            resultado = fatoracao(n, n) / fatoracao(p, p);

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("permutacao");
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
