using IntroduccionCleanArchitecture.DTOs;
using IntroduccionCleanArchitecture.Entities.Interfaces;
using IntroduccionCleanArchitecture.Entities.POCOs;
using IntroduccionCleanArchitecture.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork, ICreateProductOutputPort createProductOutputPort) =>
        (_productRepository, _unitOfWork, _createProductOutputPort) = (productRepository, unitOfWork, createProductOutputPort);

        public async Task Handle(CreateProductDTO createProductDTO)
        {
            Product newProduct = new Product { Name = createProductDTO.ProductName };
        }
    }
}
