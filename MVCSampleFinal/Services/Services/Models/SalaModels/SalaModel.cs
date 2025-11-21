using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.SalaModels
{
    public class SalaModel
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Ubicacion { get; set; } = string.Empty;
        public int Capacidad { get; set; }

        public string Estado { get; set; } = string.Empty;

        // Propiedad calculada en AutoMapper
        public int CantidadEquipos { get; set; }
        public IList<SalaModel> Salas { get; set; } = new List<SalaModel>();

    }

}
