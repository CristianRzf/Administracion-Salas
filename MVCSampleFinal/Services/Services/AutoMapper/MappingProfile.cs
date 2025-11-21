using AutoMapper;
using Domain;
using Domain.Entities;
using Services.Models.CowModels;
using Services.Models.EquipoModels;
using Services.Models.FarmModels;
using Services.Models.MilkModels;
using Services.Models.PrestamoModels;
using Services.Models.ReporteModels;
using Services.Models.SalaModels;
using Services.Models.UsuarioModels;

namespace Services.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            FarmMapper();
            MilkMapper();
            CowMapper();
            SalaMapper();
            EquipoMapper();
            UsuarioMapper();
            PrestamoMapper();
            ReporteMapper();

        }

        private void MilkMapper()
        {
            CreateMap<Milk, MilkModel>()
            .ReverseMap();

        }

        private void CowMapper()
        {
            CreateMap<Cow, CowModel>()
            .ReverseMap();

            CreateMap<Cow, AddCowModel>()
            .ReverseMap();

        }

        private void FarmMapper()
        {
            CreateMap<Farm, FarmModel>()
                .ForMember(dest => dest.CowCount,
                           opt => opt.MapFrom(src => src.Cows != null ? src.Cows.Count : 0))
                .ForMember(dest => dest.TotalMilkLitters,opt => opt.MapFrom(src => src.getTotalLitters()))
            .ReverseMap();

            CreateMap<Farm, AddFarmModel>()
                .ReverseMap();
        }
        
        public void SalaMapper()
        {
            CreateMap<Sala, SalaModel>()
                .ForMember(dest => dest.CantidadEquipos,
                    opt => opt.MapFrom(src => src.Equipos != null ? src.Equipos.Count : 0))
                .ForMember(dest => dest.Estado,
                    opt => opt.MapFrom(src => src.Estado.ToString()))
                .ReverseMap();

            CreateMap<Sala, AddSalaModel>()
                .ReverseMap();
        }
        public void EquipoMapper()
        {
            CreateMap<Equipo, EquipoModel>()
                .ForMember(dest => dest.Estado,
                    opt => opt.MapFrom(src => src.Estado.ToString()))
                .ForMember(dest => dest.SalaNombre,
                    opt => opt.MapFrom(src => src.Sala != null ? src.Sala.Nombre : string.Empty))
                .ForMember(dest => dest.SalaId,
                    opt => opt.MapFrom(src => src.SalaId))
                .ReverseMap();

            CreateMap<Equipo, AddEquipoModel>()
                .ReverseMap();
        }

        public void UsuarioMapper()
        {

            // PARA MOSTRAR USUARIOS EN EL LISTADO
            CreateMap<Usuario, UsuarioModel>()
                .ForMember(dest => dest.TotalPrestamos,
                    opt => opt.MapFrom(src => src.Prestamos != null ? src.Prestamos.Count : 0))
                .ForMember(dest => dest.TotalReportes,
                    opt => opt.MapFrom(src => src.Reportes != null ? src.Reportes.Count : 0));

            // PARA CREAR USUARIOS NUEVOS
            CreateMap<AddUsuarioModel, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(dest => dest.Prestamos, opt => opt.Ignore())
                .ForMember(dest => dest.Reportes, opt => opt.Ignore());
        }
        public void PrestamoMapper()
        {
            CreateMap<Prestamo, PrestamoModel>()
        .ForMember(dest => dest.UsuarioNombre,
            opt => opt.MapFrom(src => src.Usuario != null ? src.Usuario.Nombre : string.Empty))
        .ForMember(dest => dest.EquipoSerial,
            opt => opt.MapFrom(src => src.Equipo != null ? src.Equipo.Serial : string.Empty))
        .ForMember(dest => dest.Estado,
            opt => opt.MapFrom(src => src.Estado.ToString()));

            CreateMap<AddPrestamoModel, Prestamo>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(_ => Guid.NewGuid()));
        }

        public void ReporteMapper()
        {
            CreateMap<Reporte, ReporteModel>()
                .ForMember(dest => dest.Tipo,
                    opt => opt.MapFrom(src => src.Tipo.ToString()))
                .ForMember(dest => dest.Estado,
                    opt => opt.MapFrom(src => src.Estado.ToString()))
                .ForMember(dest => dest.UsuarioNombre,
                    opt => opt.MapFrom(src => src.Usuario != null ? src.Usuario.Nombre : string.Empty))
                .ForMember(dest => dest.SalaNombre,
                    opt => opt.MapFrom(src => src.Sala != null ? src.Sala.Nombre : string.Empty))
                .ForMember(dest => dest.EquipoSerial,
                    opt => opt.MapFrom(src => src.Equipo != null ? src.Equipo.Serial : string.Empty))
                .ReverseMap();

            CreateMap<Reporte, AddReporteModel>()
                .ReverseMap();
        }
    }

    
}
