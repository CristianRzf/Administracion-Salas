using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models.UsuarioModels
{
    public class UsuariosModel
    {
        public IList<UsuarioModel> Usuarios { get; set; } = new List<UsuarioModel>();
    }
}
