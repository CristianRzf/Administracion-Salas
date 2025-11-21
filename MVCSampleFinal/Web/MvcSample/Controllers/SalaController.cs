using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models.SalaModels;

namespace MvcSample.Controllers
{
    public class SalaController : Controller
    {
        private ISalaService SalaService { get; set; }

        public SalaController(ISalaService salaService)
        {
            SalaService = salaService;
        }

        // LISTADO DE SALAS
        public async Task<IActionResult> Index()
        {
            IList<SalaModel> salas = await SalaService.GetSalas();
            return View(salas);
        }

        // FORMULARIO PARA AGREGAR SALA (GET)
        public IActionResult AddSala()
        {
            AddSalaModel model = new AddSalaModel();
            return View(model);
        }

        // GUARDAR SALA (POST)
        [HttpPost]
        public async Task<IActionResult> AddSala(AddSalaModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await SalaService.AddSala(model);
                    return RedirectToAction("Index", "Sala");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al agregar la sala.");
                    ViewBag.Error = e.Message;
                    return View(model);
                }
            }

            return View(model);
        }
    }
}
