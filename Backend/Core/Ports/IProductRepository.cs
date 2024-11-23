using LoginEficaz.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginEficaz.Core.Ports
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProductsByBrandId(int brandId);
        Task RegisterProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
        Task UpdateImage();
    }
}