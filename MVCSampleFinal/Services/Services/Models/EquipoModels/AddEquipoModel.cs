using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.EquipoModels
{
    public class AddEquipoModel
    {
        public string Serial { get; set; } = string.Empty;
        public Guid SalaId { get; set; }
        public string Estado { get; set; }

    }
}
