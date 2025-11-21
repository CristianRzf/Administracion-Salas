using Services.Models.EquipoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEquipoService
    {
        Task AddEquipo(AddEquipoModel model);
        Task<IList<EquipoModel>> GetEquipos();
        Task<EquipoModel> GetEquipo(Guid id);
    }
}
