using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrutorTests.Models;

namespace ScrutorTests.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetById(Guid id)
        {
            return new Product()
            {
                Id = id
            };
        }
    }

    public interface IProductRepository : IRepository
    {
        Product GetById(Guid id);
    }
}
