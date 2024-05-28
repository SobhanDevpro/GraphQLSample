using MyGrapghQLSample.Models;

namespace MyGrapghQLSample.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id= 1,Name= "Laptop",Quantity= 20},
                new Product { Id= 2,Name= "Mouse",Quantity= 30},
                new Product { Id= 3,Name= "Keyboard",Quantity= 10},
                new Product { Id= 4,Name= "Monitor",Quantity= 40},
            };
        }
    }
}
