using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.PrestamoModels
{
    public class PrestamosModel
    {
        public IList<PrestamoModel> Prestamos { get; set; } = new List<PrestamoModel>();
    }
}
