using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Equipo
    {

        [Key]
        public Guid Id { get; set; }
        public string Serial { get; set; }
        public EquipoEstado Estado { get; set; }

        public Guid SalaId { get; set; }
        public Sala Sala { get; set; }
    }
}
