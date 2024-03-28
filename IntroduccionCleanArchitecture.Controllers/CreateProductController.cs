using IntroduccionCleanArchitecture.DTOs;
using IntroduccionCleanArchitecture.Presenters;
using IntroduccionCleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort _createProductInputPort;
        readonly ICreateProductOutputPort _createProductOutputPort;

        public CreateProductController(ICreateProductInputPort createProductInputPort, ICreateProductOutputPort createProductOutputPort)
        {
            _createProductInputPort = createProductInputPort;
            _createProductOutputPort = createProductOutputPort;
        }

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await _createProductInputPort.Handle(product);
            return ((IPresenter<ProductDTO>)_createProductOutputPort).Content;
        }

    }
}
