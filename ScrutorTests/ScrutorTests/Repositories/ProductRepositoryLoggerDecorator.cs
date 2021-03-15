using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ScrutorTests.Models;

namespace ScrutorTests.Repositories
{
    [Decorator]
    public class ProductRepositoryLoggerDecorator : IProductRepository
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductRepositoryLoggerDecorator> _logger;

        public ProductRepositoryLoggerDecorator(IProductRepository productRepository, ILogger<ProductRepositoryLoggerDecorator> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public Product GetById(Guid id)
        {
            var repositoryType = _productRepository.GetType();

            _logger.LogInformation($"Executing {repositoryType.Namespace} GetById - id: {id}");

            var product = _productRepository.GetById(id);

            _logger.LogInformation($"Executed {repositoryType.Namespace} GetById - id: {id}");

            return product;
        }
    }
}
