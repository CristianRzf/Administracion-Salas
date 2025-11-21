using Services.Models.ReporteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IReporteService
    {
        Task AddReporte(AddReporteModel model);
        Task<IList<ReporteModel>> GetReportes();
        Task<ReporteModel> GetReporte(Guid id);
    }
}
