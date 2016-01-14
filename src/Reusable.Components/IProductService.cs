using System.Threading.Tasks;

namespace Reusable.Components
{
    public interface IProductService
    {
        Task<Product[]> GetPromotedProducts();
    }
}