using Services.Models.SalaModels;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISalaService
    {
        Task AddSala(AddSalaModel model);
        Task<IList<SalaModel>> GetSalas();
        Task<SalaModel> GetSala(Guid id);

    }
}
