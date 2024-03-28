using IntroduccionCleanArchitecture.DTOs;
using IntroduccionCleanArchitecture.Entities.Interfaces;
using IntroduccionCleanArchitecture.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IGetAllProductOutputPort _getAllProductOutputPort;

        public GetAllProductsInteractor(IProductRepository productRepository, IGetAllProductOutputPort getAllProductOutputPort) =>
        (_productRepository, _getAllProductOutputPort) = (productRepository, getAllProductOutputPort);
        public Task Handle()
        {
            var products = _productRepository.GetAll().Select(p => new ProductDTO { Id = p.Id, Name = p.Name });
            _getAllProductOutputPort.Handle(products);
            return Task.CompletedTask;
        }
    }
}
