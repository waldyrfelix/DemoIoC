using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DemoIoC.Domain;
using DemoIoC.Domain.Entities;
using DemoIoC.Repository.EntityFramework;

namespace DemoIoC.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DemoIoCContext context;

        public ProductRepository()
        {
            Database.SetInitializer(new DataInitializer());
            context = new DemoIoCContext();
        }

        public ICollection<Product> GetAll(Func<Product, bool> filter)
        {
            return context.Products
                .Where(filter)
                .ToList();
        }
    }
}
