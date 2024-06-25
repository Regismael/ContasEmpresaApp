using ContasEmpresaApp.DOMAIN.Interfaces.Repositories;
using ContasEmpresaApp.DOMAIN.Interfaces.Services;
using ContasEmpresaApp.DOMAIN.Services;
using ContasEmpresaApp.Infra.DATA.Repositories;

namespace ContasEmpresaApp.API.Configurations
{
    public class DependencyInjectionConfiguration
    {
        public static void Configure(IServiceCollection services)
        {    
            services.AddTransient<IContaDomainService, ContaDomainService>();
            services.AddTransient<IContaRepository, ContaRepository>();
        }
    }
}
