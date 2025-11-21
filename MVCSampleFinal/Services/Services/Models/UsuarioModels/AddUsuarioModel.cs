using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.UsuarioModels
{
    public class AddUsuarioModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // Admin, Coordinador, Usuario
        public string Rol { get; set; } = string.Empty;
    }
}
