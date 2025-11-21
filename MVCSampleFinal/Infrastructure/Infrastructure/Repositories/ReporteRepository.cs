using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ReporteRepository : BaseRepository, IReporteRepository
    {

        public ReporteRepository(AppDbContext context) : base(context) { }

        public async Task<IList<Reporte>> GetReportes()
        {
            return await context.Reportes
                .Include(x => x.Usuario)
                .Include(x => x.Sala)
                .Include(x => x.Equipo)
                .ToListAsync();
        }

        public async Task<Reporte> GetReporte(Guid id)
        {
            return await context.Reportes
                .Include(x => x.Usuario)
                .Include(x => x.Sala)
                .Include(x => x.Equipo)
                .FirstAsync(x => x.Id == id);
        }

        public async Task Save(Reporte reporte)
        {
            await Beguin();
            await context.Reportes.AddAsync(reporte);
            await context.SaveChangesAsync();
            await Comit();
        }

        public async Task Update()
        {
            await Beguin();
            await context.SaveChangesAsync();
            await Comit();
        }

    }
}
