﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.UseCasesPorts
{
    public interface IGetAllProductInputPort
    {
        Task Handle(); 
    }
}
