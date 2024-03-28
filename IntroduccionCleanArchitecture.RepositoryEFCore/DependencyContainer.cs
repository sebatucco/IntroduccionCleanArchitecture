using IntroduccionCleanArchitecture.Entities.Interfaces;
using IntroduccionCleanArchitecture.Repository.EFCore.DataContext;
using IntroduccionCleanArchitecture.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.RepositoryEFCore
{
    public static class DependencyContainer
    {
        // metodo de extension de IServiceCollection y permite leer la configuracion
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer(configuration.GetConnectionString("IntroduccionCleanArchitectureConnectionString")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
