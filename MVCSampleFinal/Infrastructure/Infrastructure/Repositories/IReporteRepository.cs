using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IReporteRepository
    {
        Task<IList<Reporte>> GetReportes();
        Task<Reporte> GetReporte(Guid id);
        Task Save(Reporte reporte);
        Task Update();
    }
}
