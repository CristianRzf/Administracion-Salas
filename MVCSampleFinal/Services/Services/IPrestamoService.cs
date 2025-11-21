using Services.Models.PrestamoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IPrestamoService
    {
        Task AddPrestamo(AddPrestamoModel model);
        Task<IList<PrestamoModel>> GetPrestamos();
        Task<PrestamoModel> GetPrestamo(Guid id);
    }
}
