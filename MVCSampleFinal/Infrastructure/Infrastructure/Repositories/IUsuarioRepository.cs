using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IList<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuario(Guid id);
        Task Save(Usuario usuario);
        Task Update();
    }
}
