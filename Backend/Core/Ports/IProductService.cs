using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<List<ProductDTO>> GetProductsByBrandId(int brandId);
        Task RegisterProduct(ProductDTO product);
        Task UpdateProduct(ProductDTO product);
        Task DeleteProduct(int id);
    }
}
