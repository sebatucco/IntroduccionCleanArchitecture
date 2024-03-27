using IntroduccionCleanArchitecture.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO createProductDTO);
    }
}
