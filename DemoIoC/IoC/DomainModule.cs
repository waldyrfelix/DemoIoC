using DemoIoC.Domain;
using DemoIoC.Domain.Services;
using DemoIoC.Repository;
using Ninject.Modules;

namespace DemoIoC.Web.IoC
{
    public class DomainModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>();
            Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}