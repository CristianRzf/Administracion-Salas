using Services.Models.UsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUsuarioService
    {
        Task AddUsuario(AddUsuarioModel model);
        Task<IList<UsuarioModel>> GetUsuarios();
        Task<UsuarioModel> GetUsuario(Guid id);
    }
}
