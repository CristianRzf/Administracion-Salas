using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models.UsuarioModels;

namespace MvcSample.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioService UsuarioService { get; set; }

        public UsuarioController(IUsuarioService usuarioService)
        {
            UsuarioService = usuarioService;
        }

        // LISTADO DE USUARIOS
        public async Task<IActionResult> Index()
        {
            IList<UsuarioModel> usuarios = await UsuarioService.GetUsuarios();
            return View(usuarios);
        }

        // FORMULARIO PARA AGREGAR USUARIO (GET)
        public IActionResult AddUsuario()
        {
            AddUsuarioModel model = new AddUsuarioModel();
            return View(model);
        }

        // GUARDAR USUARIO (POST)
        [HttpPost]
        public async Task<IActionResult> AddUsuario(AddUsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await UsuarioService.AddUsuario(model);
                    return RedirectToAction("Index", "Usuario");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al agregar el usuario.");
                    ViewBag.Error = e.Message;
                    return View(model);
                }
            }

            return View(model);
        }
    }
}
