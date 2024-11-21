using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        void AddProduct(ProductDTO product);
        void UpdateProduct(ProductDTO product);
        void DeleteProduct(int id);
    }
}
