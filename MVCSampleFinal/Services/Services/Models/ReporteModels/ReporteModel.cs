using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.ReporteModels
{
    public class ReporteModel
    {
        public Guid Id { get; set; }

        public string Tipo { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }

        public Guid UsuarioId { get; set; }
        public string UsuarioNombre { get; set; } = string.Empty;

        public Guid? SalaId { get; set; }
        public string SalaNombre { get; set; } = string.Empty;

        public Guid? EquipoId { get; set; }
        public string EquipoSerial { get; set; } = string.Empty;
    }
}
