using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.PrestamoModels
{
    public class PrestamoModel
    {
        public Guid Id { get; set; }

        public Guid UsuarioId { get; set; }
        public string UsuarioNombre { get; set; } = string.Empty;

        public Guid EquipoId { get; set; }
        public string EquipoSerial { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Estado { get; set; } = string.Empty;
    }
}
