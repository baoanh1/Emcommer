﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services
{
    public interface IRepositoryFactory
    {
        IRepository<T> GetRepository<T>() where T : class;
    }
}
