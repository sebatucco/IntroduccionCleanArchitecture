using IntroduccionCleanArchitecture.Presenters;
using IntroduccionCleanArchitecture.RepositoryEFCore;
using IntroduccionCleanArchitecture.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddIntroduccionCleanArchitectureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
