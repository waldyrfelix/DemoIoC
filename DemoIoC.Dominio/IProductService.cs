using System.Collections.Generic;
using DemoIoC.Domain.Entities;

namespace DemoIoC.Domain
{
    public interface IProductService
    {
        ICollection<Product> GetAllActiveProducts();
    }
}