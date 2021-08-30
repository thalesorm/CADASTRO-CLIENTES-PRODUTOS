using Data.Repository;
using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using Services.Interface;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Ioc
{
    public static class Injector
    {
        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped(typeof(IProdutoService), typeof(ProdutoService));
            services.AddScoped(typeof(IClienteService), typeof(ClienteService));

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));
            services.AddScoped(typeof(IClienteRepository), typeof(ClienteRepository));

            
        }
    }
}
