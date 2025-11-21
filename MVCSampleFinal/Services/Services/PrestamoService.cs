using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Services.Models.PrestamoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class PrestamoService : IPrestamoService
    {
        private IPrestamoRepository PrestamoRepository { get; set; }
        private IMapper Mapper { get; set; }
        private IConfiguration Configuration { get; set; }

        public PrestamoService(IMapper mapper, IConfiguration configuration, IPrestamoRepository prestamoRepository)
        {
            Mapper = mapper;
            Configuration = configuration;
            PrestamoRepository = prestamoRepository;
        }

        public async Task<IList<PrestamoModel>> GetPrestamos()
        {
            var prestamos = await PrestamoRepository.GetPrestamos();
            return Mapper.Map<IList<PrestamoModel>>(prestamos);
        }

        public async Task<PrestamoModel> GetPrestamo(Guid id)
        {
            var prestamo = await PrestamoRepository.GetPrestamo(id);
            return Mapper.Map<PrestamoModel>(prestamo);
        }

        public async Task AddPrestamo(AddPrestamoModel model)
        {
            var entity = Mapper.Map<Prestamo>(model);
            await PrestamoRepository.Save(entity);
        }
    }
}