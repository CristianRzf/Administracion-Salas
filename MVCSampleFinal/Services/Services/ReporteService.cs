using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Services.Models.ReporteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReporteService : IReporteService
    {
        private IReporteRepository ReporteRepository { get; set; }
        private IMapper Mapper { get; set; }
        private IConfiguration Configuration { get; set; }

        public ReporteService(IMapper mapper, IConfiguration configuration, IReporteRepository reporteRepository)
        {
            Mapper = mapper;
            Configuration = configuration;
            ReporteRepository = reporteRepository;
        }

        public async Task<IList<ReporteModel>> GetReportes()
        {
            var reportes = await ReporteRepository.GetReportes();
            return Mapper.Map<IList<ReporteModel>>(reportes);
        }

        public async Task<ReporteModel> GetReporte(Guid id)
        {
            var reporte = await ReporteRepository.GetReporte(id);
            return Mapper.Map<ReporteModel>(reporte);
        }

        public async Task AddReporte(AddReporteModel model)
        {
            var entity = Mapper.Map<Reporte>(model);
            await ReporteRepository.Save(entity);
        }
    }
}