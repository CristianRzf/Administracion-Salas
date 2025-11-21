using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ISalaRepository
    {
        Task<IList<Sala>> GetSalas();
        Task<Sala> GetSala(Guid id);
        Task Save(Sala sala);
        Task Update();
    }
}
