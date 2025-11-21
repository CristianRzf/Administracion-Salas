using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.EquipoModels
{
    public class EquiposModel
    {
        public IList<EquipoModel> Equipos { get; set; } = new List<EquipoModel>();
    }
}
