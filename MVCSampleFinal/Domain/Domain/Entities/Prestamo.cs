using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prestamo
    {

        [Key]
        public Guid Id { get; set; }

        public Guid EquipoId { get; set; }
        public Equipo Equipo { get; set; }

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public SolicitudEstado Estado { get; set; }

        public void Aprobar()
        {
            Estado = SolicitudEstado.Aprobada;
        }

        public void Rechazar()
        {
            Estado = SolicitudEstado.Rechazada;
        }
    }
}
