using GetProductAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProductAPI.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
