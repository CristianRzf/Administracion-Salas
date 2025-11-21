using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models.ReporteModels;

namespace MvcSample.Controllers
{
    public class ReporteController : Controller
    {
        private IReporteService ReporteService { get; set; }

        public ReporteController(IReporteService reporteService)
        {
            ReporteService = reporteService;
        }

        // LISTADO DE REPORTES
        public async Task<IActionResult> Index()
        {
            IList<ReporteModel> reportes = await ReporteService.GetReportes();
            return View(reportes);
        }

        // FORMULARIO PARA AGREGAR REPORTE (GET)
        public IActionResult AddReporte()
        {
            AddReporteModel model = new AddReporteModel();
            return View(model);
        }

        // GUARDAR REPORTE (POST)
        [HttpPost]
        public async Task<IActionResult> AddReporte(AddReporteModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await ReporteService.AddReporte(model);
                    return RedirectToAction("Index", "Reporte");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al agregar el reporte.");
                    ViewBag.Error = e.Message;
                    return View(model);
                }
            }

            return View(model);
        }
    }
}
