using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Services.Models.SalaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SalaService : ISalaService
    {
        private ISalaRepository SalaRepository { get; set; }
        private IMapper Mapper { get; set; }
        private IConfiguration Configuration { get; set; }

        public SalaService(IMapper mapper, IConfiguration configuration, ISalaRepository salaRepository)
        {
            Mapper = mapper;
            SalaRepository = salaRepository;
            Configuration = configuration;
        }

        public async Task<IList<SalaModel>> GetSalas()
        {
            var salas = await SalaRepository.GetSalas();
            return Mapper.Map<IList<SalaModel>>(salas);
        }

        public async Task<SalaModel> GetSala(Guid id)
        {
            var sala = await SalaRepository.GetSala(id);
            return Mapper.Map<SalaModel>(sala);
        }

        public async Task AddSala(AddSalaModel model)
        {
            var entity = Mapper.Map<Sala>(model);
            entity.Id = Guid.NewGuid();
            await SalaRepository.Save(entity);
        }
    }
}
