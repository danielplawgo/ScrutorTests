using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrutorTests.Models;

namespace ScrutorTests.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category GetById(Guid id)
        {
            return new Category()
            {
                Id = id
            };
        }
    }

    public interface ICategoryRepository : IRepository
    {
        Category GetById(Guid id);
    }
}
