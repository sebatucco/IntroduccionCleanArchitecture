using IntroduccionCleanArchitecture.DTOs;
using IntroduccionCleanArchitecture.Presenters;
using IntroduccionCleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductInputPort _getAllProductInputPort;
        readonly IGetAllProductOutputPort _getAllProductOutputPort;

        public GetAllProductsController(IGetAllProductInputPort getAllProductInputPort, IGetAllProductOutputPort getAllProductOutputPort)
        {
            _getAllProductInputPort = getAllProductInputPort;
            _getAllProductOutputPort = getAllProductOutputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await _getAllProductInputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)_getAllProductOutputPort).Content;
        }
    }
}
