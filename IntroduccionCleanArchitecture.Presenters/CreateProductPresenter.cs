﻿using IntroduccionCleanArchitecture.DTOs;
using IntroduccionCleanArchitecture.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.Presenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO productDTO)
        {
            Content = productDTO;
            return Task.CompletedTask;
        }
    }
}
