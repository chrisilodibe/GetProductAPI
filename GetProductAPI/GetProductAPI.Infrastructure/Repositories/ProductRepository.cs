using GetProductAPI.Domain;
using GetProductAPI.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetProductAPI.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Car", Description = "Benz made" },
                new Product { Id = 2, Name = "Fan", Description = "Ox made" },
                new Product { Id = 3, Name = "Chair", Description = "Fabric made" }
            };
        }
    }
}
