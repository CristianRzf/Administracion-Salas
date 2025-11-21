using Microsoft.AspNetCore.Mvc;
using MvcSample.Models;
using System.Diagnostics;

namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // DASHBOARD / PÁGINA PRINCIPAL
        public IActionResult Index()
        {
            return View();
        }

        // INFORMACIÓN DE PRIVACIDAD (SI LA USAS)
        public IActionResult Privacy()
        {
            return View();
        }

        // MANEJO DE ERRORES DEL SISTEMA
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
