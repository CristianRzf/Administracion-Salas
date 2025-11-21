using Services.Models.EquipoModels;
using Services.Models.UsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.PrestamoModels
{
    public class AddPrestamoModel
    {
        public Guid EquipoId { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = string.Empty;
        public IList<UsuarioModel> Usuarios { get; set; } = new List<UsuarioModel>();
        public IList<EquipoModel> Equipos { get; set; } = new List<EquipoModel>();
    }
}
