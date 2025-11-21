using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class SalaRepository : BaseRepository, ISalaRepository
    {

        public SalaRepository(AppDbContext context) : base(context) { }

        public async Task<IList<Sala>> GetSalas()
        {
            return await context.Salas
                .Include(x => x.Equipos)
                .ToListAsync();
        }

        public async Task<Sala> GetSala(Guid id)
        {
            return await context.Salas
                .Include(x => x.Equipos)
                .FirstAsync(x => x.Id == id);
        }

        public async Task Save(Sala sala)
        {
            await context.Salas.AddAsync(sala);
            await context.SaveChangesAsync();
        }

        public async Task Update()
        {
            await context.SaveChangesAsync();


        }
    }
}
