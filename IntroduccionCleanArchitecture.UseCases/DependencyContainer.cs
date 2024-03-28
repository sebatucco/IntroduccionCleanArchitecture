using IntroduccionCleanArchitecture.UseCases.CreateProduct;
using IntroduccionCleanArchitecture.UseCases.GetAllProducts;
using IntroduccionCleanArchitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductInputPort, GetAllProductsInteractor>();
            return services;
        }
    }
}
