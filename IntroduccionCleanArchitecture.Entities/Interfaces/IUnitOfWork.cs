﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCleanArchitecture.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> Savechanges();
    }
}
