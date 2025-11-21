using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.UsuarioModels
{
    public class UsuarioModel
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;

        // Cantidad de acciones del usuario
        public int TotalPrestamos { get; set; }
        public int TotalReportes { get; set; }
    }
}
