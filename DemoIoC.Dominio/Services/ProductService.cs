using System.Collections.Generic;
using DemoIoC.Domain.Entities;

namespace DemoIoC.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ICollection<Product> GetAllActiveProducts()
        {
            return productRepository.GetAll(product => product.IsActive);
        }
    }
}