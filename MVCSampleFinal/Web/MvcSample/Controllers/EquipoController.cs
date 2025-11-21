using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services;
using Services.Models.EquipoModels;

namespace MvcSample.Controllers
{
    public class EquipoController : Controller
    {
        private readonly IEquipoService EquipoService;
        private readonly ISalaService SalaService;

        public EquipoController(IEquipoService equipoService, ISalaService salaService)
        {
            EquipoService = equipoService;
            SalaService = salaService;
        }

        // LISTADO DE EQUIPOS
        public async Task<IActionResult> Index()
        {
            IList<EquipoModel> equipos = await EquipoService.GetEquipos();
            return View(equipos);
        }

        // FORMULARIO (GET)
        public async Task<IActionResult> AddEquipo()
        {
            await CargarSalas();
            return View(new AddEquipoModel());
        }

        // GUARDAR (POST)
        [HttpPost]
        public async Task<IActionResult> AddEquipo(AddEquipoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await EquipoService.AddEquipo(model);
                    return RedirectToAction("Index", "Equipo");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al agregar el equipo.");
                    ViewBag.Error = e.Message;
                }
            }

            await CargarSalas();
            return View(model);
        }

        private async Task CargarSalas()
        {
            var salas = await SalaService.GetSalas();
            ViewBag.Salas = new SelectList(salas, "Id", "Nombre");
        }
    }
}
