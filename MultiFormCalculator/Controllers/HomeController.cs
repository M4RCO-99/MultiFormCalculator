using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using MultiFormCalculator.Models;
using System.Diagnostics;

namespace MultiFormCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //static void areaRetangulo()
        //{
        //    float Base;
        //    float altura;
        //    float resultado;

        //    resultado = Base * altura;
        //}

        //static void areaQuadrado()
        //{
        //    float lado;
        //    float resultado;

        //    resultado = lado * lado;
        //}

        //static void areaLosangulo()
        //{
        //    float D;
        //    float d;
        //    float resultado;

        //    resultado = D * d / 2;
        //}

        //static void areaTriangulo()
        //{
        //    float Base;
        //    float altura;
        //    float resultado;

        //    resultado = Base * altura / 2;
        //}

        //static void areaTrianguloEquilatero()
        //{
        //    float lado;
        //    float resultado;

        //    resultado = 3 * (lado * lado) / 4;
        //}

        //static void areaCirculo()
        //{
        //    float raio;
        //    float resultado;

        //    resultado = 3,14 * raio;
        //}

        //static void areaTrapezio()
        //{
        //    float baseMenor;
        //    float baseMaior;
        //    float altura;
        //    float resultado;

        //    resultado = (baseMenor + baseMaior) * altura / 2;
        //}

        //static void teoremaPitagoras()
        //{
        //    float hipotenusa;
        //    float cateto1;
        //    float cateto2;
        //    float resultado;

        //    resultado = hipotenusa * hipotenusa = cateto1 * cateto1 + cateto2 * cateto2;
        //}

        //static void jurosSimples()
        //{
        //    float C;
        //    float i;
        //    float t;
        //    float resultado;

        //    resultado = C * i * t;
        //}

        //static void jurosComposto()
        //{
        //    float C;
        //    float i;
        //    float t;
        //    float resultado;

        //    resultado = C * (1 + i) * t;
        //}

        //static void equacaoPrimeiroGrau()
        //{
        //    float a;
        //    float b;
        //    float x;
        //    float resultado;

        //    resultado = a * x + b;
        //}

        //static void equacaoSegundoGrau()
        //{
        //    float a;
        //    float b;
        //    float c;
        //    float delta;
        //    float x1;
        //    float x2;

        //    delta = b * b - 4 * a * c;
        //    x1 = -b + delta / 2 * a;
        //    x1 = -b - delta / 2 * a;
        //}

        //static void velocidade()
        //{
        //    float velocidadeInicial;
        //    float aceleração;
        //    float intervaloTempo;
        //    float resultado;

        //    resultado = velocidadeInicial + aceleração * intervaloTempo;
        //}

        //static void segundaLeiNewton()
        //{
        //    float massa;
        //    float aceleração;
        //    float resultado;

        //    resultado = massa * aceleração;
        //}

        //static void calorometria()
        //{
        //    float massa;
        //    float aceleração;
        //    float resultado;

        //    resultado = massa * aceleração;
        //}
    }
}
