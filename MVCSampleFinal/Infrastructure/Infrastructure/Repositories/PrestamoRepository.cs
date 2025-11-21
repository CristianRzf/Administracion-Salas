using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PrestamoRepository : BaseRepository, IPrestamoRepository
    {
        public PrestamoRepository(AppDbContext context) : base(context) { }

        public async Task<IList<Prestamo>> GetPrestamos()
        {
            return await context.Prestamos
                .Include(x => x.Usuario)
                .Include(x => x.Equipo)
                .ToListAsync();
        }

        public async Task<Prestamo> GetPrestamo(Guid id)
        {
            return await context.Prestamos
                .Include(x => x.Usuario)
                .Include(x => x.Equipo)
                .FirstAsync(x => x.Id == id);
        }

        public async Task Save(Prestamo prestamo)
        {
            await Beguin();
            await context.Prestamos.AddAsync(prestamo);
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
