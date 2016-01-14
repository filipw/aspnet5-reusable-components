using System.Threading.Tasks;

namespace Reusable.Components
{
    public class ProductService : IProductService
    {
        public Task<Product[]> GetPromotedProducts()
        {
            //for simplicity data is in memory
            var data = new[]
            {
                new Product
                {
                    Name = "Etape: 20 Great Stages from the Modern Tour de France",
                    Price = 9.90m
                },
                new Product
                {
                    Name = "Anarchy Evolution: Faith, Science and Bad Religion in a World Without God",
                    Price = 8.90m
                },
                new Product
                {
                    Name = "The Bright Continent: Breaking Rules and Making Changes in Modern Africa",
                    Price = 12.50m
                }
            };
            return Task.FromResult(data);
        }
    }
}