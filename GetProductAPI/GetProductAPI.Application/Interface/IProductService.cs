﻿using GetProductAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProductAPI.Application.Interface
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
