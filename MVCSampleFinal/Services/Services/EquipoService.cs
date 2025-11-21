using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Services.Models.EquipoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EquipoService : IEquipoService
    {
        private IEquipoRepository EquipoRepository { get; set; }
        private IMapper Mapper { get; set; }
        private IConfiguration Configuration { get; set; }

        public EquipoService(IMapper mapper, IConfiguration configuration, IEquipoRepository equipoRepository)
        {
            Mapper = mapper;
            Configuration = configuration;
            EquipoRepository = equipoRepository;
        }

        public async Task<IList<EquipoModel>> GetEquipos()
        {
            var equipos = await EquipoRepository.GetEquipos();
            return Mapper.Map<IList<EquipoModel>>(equipos);
        }

        public async Task<EquipoModel> GetEquipo(Guid id)
        {
            var equipo = await EquipoRepository.GetEquipo(id);
            return Mapper.Map<EquipoModel>(equipo);
        }

        public async Task AddEquipo(AddEquipoModel model)
        {
            var entity = Mapper.Map<Equipo>(model);
            await EquipoRepository.Save(entity);
        }
    }
}
