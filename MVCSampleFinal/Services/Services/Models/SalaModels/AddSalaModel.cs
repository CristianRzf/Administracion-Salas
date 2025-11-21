using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.SalaModels
{
    public class AddSalaModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Ubicacion { get; set; } = string.Empty;
        public int Capacidad { get; set; }
    }
}
