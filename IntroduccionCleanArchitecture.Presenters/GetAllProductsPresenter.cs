using IntroduccionCleanArchitecture.DTOs;
using IntroduccionCleanArchitecture.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//inplementacion de output port

namespace IntroduccionCleanArchitecture.Presenters
{
    public class GetAllProductsPresenter : IGetAllProductOutputPort, IPresenter<IEnumerable<ProductDTO>>
    {
        public IEnumerable<ProductDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDTO> productDTOs)
        {
            Content = productDTOs;
            return Task.CompletedTask;
        }
    }
}
