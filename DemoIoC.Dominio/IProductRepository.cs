using System;
using System.Collections.Generic;
using DemoIoC.Domain.Entities;

namespace DemoIoC.Domain
{
    public interface IProductRepository
    {
        ICollection<Product> GetAll(Func<Product,bool> filter);
    }
}
