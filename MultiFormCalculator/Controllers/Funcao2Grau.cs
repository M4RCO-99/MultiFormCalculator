using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace MultiFormCalculator.Controllers
{
    public class Funcao2Grau : Controller
    {
        [HttpGet]
        public IActionResult funcao2Grau()
        {
            return View();
        }

        [HttpPost]
        public IActionResult funcao2Grau(double a, double b, double c)
        {
            double delta;
            double x1;
            double x2;
            double raiz;
            string log;

            log = "Delta = " + b + " * " + b + " - " + 4 + " * " + a + " * " + c + "\n";
            log += " " + "Delta = " + (b * b) + " - " + 4 + " * " + a + " * " + c + "\n";
            log += " " + "Delta = " + (b * b) + " - " + 4 + " * " + (a * c) + "\n";
            log += " " + "Delta = " + (b * b) + " + " + "(" + (-4 * (a * c)) + ")" + "\n";

            delta = b * b - 4 * a * c;

            log += " " + delta + "\n\n";

            if (Convert.ToString(delta).Contains("-"))
            {
                log += " " + "Não é possível calcular a raiz quadrada de um valor negativo!";
            }
            else
            {
                raiz = Math.Round(Math.Sqrt(delta), 2);

                log += " " + "X1 = " + -b + " + " + "raiz de Delta" + " / " + 2 + " * " + a + "\n";
                log += " " + "X1 = " + -b + " + " + raiz + " / " + 2 + " * " + a + "\n";
                log += " " + "X1 = " + -b + " + " + raiz + " / " + (2 * a) + "\n";
                log += " " + "X1 = " + (-b + raiz) + " / " + (2 * a) + "\n";

                x1 = (-b + raiz) / (2 * a);

                log += " " + "X1 = " + x1 + "\n\n";

                log += " " + "X2 = " + -b + " - " + "raiz de Delta" + " / " + 2 + " * " + a + "\n";
                log += " " + "X2 = " + -b + " - " + raiz + " / " + 2 + " * " + a + "\n";
                log += " " + "X2 = " + -b + " - " + raiz + " / " + (2 * a) + "\n";
                log += " " + "X2 = " + (-b - raiz) + " / " + (2 * a) + "\n";

                x2 = (-b - raiz) / (2 * a);

                log += " " + "X2 = " + x2;
            }

            ViewBag.resultado = log;

            return View("funcao2Grau");
        }
    }
}