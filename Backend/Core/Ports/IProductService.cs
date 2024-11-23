using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;

namespace LoginEficaz.Core.Ports
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<List<ProductDTO>> GetProductsByBrandId(int brandId);
        public Task<string> UploadProductImage(int prodId, FileData file);
        Task RegisterProduct(ProductDTO product);
        Task UpdateProduct(ProductDTO product);
        Task DeleteProduct(int id);
    }
}
