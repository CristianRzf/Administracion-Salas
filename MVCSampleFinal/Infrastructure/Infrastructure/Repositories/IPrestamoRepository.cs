using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IPrestamoRepository
    {
        Task<IList<Prestamo>> GetPrestamos();
        Task<Prestamo> GetPrestamo(Guid id);
        Task Save(Prestamo prestamo);
        Task Update();
    }
}
