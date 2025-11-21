using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Services.Models.UsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository UsuarioRepository { get; set; }
        private IMapper Mapper { get; set; }
        private IConfiguration Configuration { get; set; }

        public UsuarioService(IMapper mapper, IConfiguration configuration, IUsuarioRepository usuarioRepository)
        {
            Mapper = mapper;
            Configuration = configuration;
            UsuarioRepository = usuarioRepository;
        }

        public async Task<IList<UsuarioModel>> GetUsuarios()
        {
            var usuarios = await UsuarioRepository.GetUsuarios();
            return Mapper.Map<IList<UsuarioModel>>(usuarios);
        }

        public async Task<UsuarioModel> GetUsuario(Guid id)
        {
            var usuario = await UsuarioRepository.GetUsuario(id);
            return Mapper.Map<UsuarioModel>(usuario);
        }

        public async Task AddUsuario(AddUsuarioModel model)
        {
            var entity = Mapper.Map<Usuario>(model);
            await UsuarioRepository.Save(entity);
        }
    }
}