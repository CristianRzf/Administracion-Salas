using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IEquipoRepository
    {
        Task<IList<Equipo>> GetEquipos();
        Task<Equipo> GetEquipo(Guid id);
        Task Save(Equipo equipo);
        Task Update();
    }
}
