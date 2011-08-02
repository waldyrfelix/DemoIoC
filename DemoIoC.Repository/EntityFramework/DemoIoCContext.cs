using System.Data.Entity;
using DemoIoC.Domain.Entities;

namespace DemoIoC.Repository.EntityFramework
{
    public class DemoIoCContext : DbContext
    {
        public DemoIoCContext()
            : base("DbDemoIoC")
        {}

        public DbSet<Product> Products { get; set; }
    }
}
