using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Reporte
    {

        [Key]
        public Guid Id { get; set; }

        public ReporteTipo Tipo { get; set; }
        public string Descripcion { get; set; }
        public ReporteEstado Estado { get; set; }

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public Guid? SalaId { get; set; }
        public Sala? Sala { get; set; }

        public Guid? EquipoId { get; set; }
        public Equipo? Equipo { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public void MarcarComoResuelto()
        {
            Estado = ReporteEstado.Resuelto;
        }
    }
}
