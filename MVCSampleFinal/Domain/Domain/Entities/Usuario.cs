using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {

        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }   // Admin, Coordinador, Usuario
        public string Email { get; set; }
        public string Password { get; set; }


        public List<Prestamo>? Prestamos { get; set; }
        public List<Reporte>? Reportes { get; set; }
    }
}
