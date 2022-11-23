using Microsoft.AspNetCore.Mvc;

namespace MultiFormCalculator.Controllers
{
    public class Combinacao : Controller
    {
        [HttpGet]
        public IActionResult combinacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult combinacao(double n, double p)
        {
            double resultado;
            string log;

            if (n < p)
            {
                ViewBag.resultado = "n deve ser maior que p";

                return View("arranjo");
            }

            log = n + "!" + " / " + p + "!" + " * " + "(" + n + " - " + p + ")!" + "\n";
            log += " " + fatoracao(n, n) + " / " + p + "!" + " * " + "(" + n + " - " + p + ")!" + "\n";
            log += " " + fatoracao(n, n) + " / " + p + "!" + " * " + fatoracao(n - p, n - p) + "\n";
            log += " " + fatoracao(n, n) + " / " + fatoracao(p, p) + " * " + fatoracao(n - p, n - p) + "\n";
            log += " " + fatoracao(n, n) + " / " + (fatoracao(p, p) * fatoracao(n - p, n - p)) + "\n";

            resultado = fatoracao(n, n) / fatoracao(p, p) * fatoracao(n - p, n - p);

            log += " " + resultado;

            ViewBag.resultado = log;

            return View("combinacao");
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
