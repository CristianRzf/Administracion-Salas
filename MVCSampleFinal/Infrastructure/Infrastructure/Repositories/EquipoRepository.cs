using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EquipoRepository : BaseRepository, IEquipoRepository
    {

        public EquipoRepository(AppDbContext context) : base(context) { }

        public async Task<IList<Equipo>> GetEquipos()
        {
            return await context.Equipos
                .Include(x => x.Sala)
                .ToListAsync();
        }

        public async Task<Equipo> GetEquipo(Guid id)
        {
            return await context.Equipos
                .Include(x => x.Sala)
                .FirstAsync(x => x.Id == id);
        }

        public async Task Save(Equipo equipo)
        {
            await Beguin();
            await context.Equipos.AddAsync(equipo);
            await Save();
            await Comit();
        }

        public async Task Update()
        {
            await Beguin();
            await Comit();
            await Save();

        }
    }
}
