using Microsoft.Extensions.DependencyInjection;

namespace Services
{
    public static class Dependencyinjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
          
            services.AddTransient<IFarmService, FarmService>();
            services.AddTransient<ISalaService, SalaService>();
            services.AddTransient<IEquipoService, EquipoService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IPrestamoService, PrestamoService>();
            services.AddTransient<IReporteService, ReporteService>();
            return services;
        }
    }
}
