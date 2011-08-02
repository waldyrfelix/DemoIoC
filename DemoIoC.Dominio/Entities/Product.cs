namespace DemoIoC.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int QuantityInStock { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
