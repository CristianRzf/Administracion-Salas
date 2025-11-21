using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.ReporteModels
{
    public class ReportesModel
    {
        public IList<ReporteModel> Reportes { get; set; } = new List<ReporteModel>();
    }
}
