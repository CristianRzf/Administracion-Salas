using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sala
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public SalaEstado Estado { get; set; }
        public int Capacidad { get; set; }

        public List<Equipo>? Equipos { get; set; } = new List<Equipo>();

        public bool EstaDisponible()
        {
            return Estado == SalaEstado.Disponible;
        }
    }
}
