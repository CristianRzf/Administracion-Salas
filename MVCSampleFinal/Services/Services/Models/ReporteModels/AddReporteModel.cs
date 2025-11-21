using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.ReporteModels
{
    public class AddReporteModel
    {
        public Guid UsuarioId { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // "Sala" o "Equipo"

        public Guid? SalaId { get; set; }
        public Guid? EquipoId { get; set; }
    }
}
