using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {

        public UsuarioRepository(AppDbContext context) : base(context) { }

        public async Task<IList<Usuario>> GetUsuarios()
        {
            return await context.Usuarios
                .Include(x => x.Prestamos)
                .Include(x => x.Reportes)
                .ToListAsync();
        }

        public async Task<Usuario> GetUsuario(Guid id)
        {
            return await context.Usuarios
                .Include(x => x.Prestamos)
                .Include(x => x.Reportes)
                .FirstAsync(x => x.Id == id);
        }

        public async Task Save(Usuario usuario)
        {
            await Beguin();
            await context.Usuarios.AddAsync(usuario);
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
