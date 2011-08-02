using System.Collections.Generic;
using System.Data.Entity;
using DemoIoC.Domain.Entities;

namespace DemoIoC.Repository.EntityFramework
{
    public class DataInitializer : CreateDatabaseIfNotExists<DemoIoCContext>
    {
        private IEnumerable<Product> getAllInitialProducts()
        {
            yield return new Product { IsActive = false, Name = "Camisa Polo", Price = 45.3m, QuantityInStock = 3 };
            yield return new Product { IsActive = true, Name = "Calça Jeans", Price = 55.5m, QuantityInStock = 71 };
            yield return new Product { IsActive = true, Name = "Casaco Couro", Price = 100m, QuantityInStock = 34 };
            yield return new Product { IsActive = true, Name = "Blazer Preto", Price = 84m, QuantityInStock = 56 };
            yield return new Product { IsActive = true, Name = "Cueca de Copinho", Price = 12.6m, QuantityInStock = 12 };
            yield return new Product { IsActive = true, Name = "Camisa da Seleção", Price = 1.5m, QuantityInStock = 545 };
        }


        protected override void Seed(DemoIoCContext context)
        {

            foreach (var product in getAllInitialProducts())
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
