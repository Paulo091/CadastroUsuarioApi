using CadastroUsuarios.Data.Repositories;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Handlers;
using CadastroUsuarios.Domain.UsuarioRoot.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroUsuarios.Ioc
{
    public static class DependencyInjectionRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUsuarioHandler, UsuarioHandler>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
