using Microsoft.AspNetCore.Mvc;

namespace Practica18022025.AppWebMVC.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.num1 = 0;
            ViewBag.num2 = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(int op, int num1, int num2)
        {
            int resultado = num1 + num2;
            ViewBag.resultado = resultado;
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            return View("Index");
        }
    }
}
