using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.EquipoModels
{
    public class EquipoModel
    {
        public Guid Id { get; set; }
        public string Serial { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;

        // Información básica de la sala donde está
        public string SalaNombre { get; set; } = string.Empty;
        public Guid SalaId { get; set; }
    }
}
