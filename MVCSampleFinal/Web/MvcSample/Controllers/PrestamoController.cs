using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models.PrestamoModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcSample.Controllers
{
    public class PrestamoController : Controller
    {
        private readonly IPrestamoService prestamoService;
        private readonly IUsuarioService usuarioService;
        private readonly IEquipoService equipoService;

        public PrestamoController(
            IPrestamoService prestamoService,
            IUsuarioService usuarioService,
            IEquipoService equipoService)
        {
            this.prestamoService = prestamoService;
            this.usuarioService = usuarioService;
            this.equipoService = equipoService;
        }

        // LISTADO
        public async Task<IActionResult> Index()
        {
            var prestamos = await prestamoService.GetPrestamos();
            return View(prestamos);
        }

        // FORMULARIO GET
        public async Task<IActionResult> AddPrestamo()
        {
            await CargarListas();
            return View(new AddPrestamoModel());
        }

        // POST GUARDAR
        [HttpPost]
        public async Task<IActionResult> AddPrestamo(AddPrestamoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await prestamoService.AddPrestamo(model);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ocurrió un error al agregar el préstamo.");
                    ViewBag.Error = ex.Message;
                }
            }

            await CargarListas();
            return View(model);
        }

        // MÉTODO PRIVADO PARA CARGAR USUARIOS Y EQUIPOS
        private async Task CargarListas()
        {
            var usuarios = await usuarioService.GetUsuarios();
            var equipos = await equipoService.GetEquipos();

            // PROPIEDADES CORRECTAS
            ViewBag.Usuarios = new SelectList(usuarios, "Id", "NombreCompleto");
            ViewBag.Equipos = new SelectList(equipos, "Id", "Nombre");
        }
    }
}
