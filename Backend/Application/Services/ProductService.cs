using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;

namespace LoginEficaz.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return _products.Select(p => new ProductDTO
            {
                ProdId = p.ProdId,
                ProdName = p.ProdName,
                Brand = p.Brand,
                Price = p.Price,
                Description = p.Description,
                ImageUrl = p.ImageUrl
            });
        }

        public ProductDTO GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProdId == id);
            if (product == null) return null;

            return new ProductDTO
            {
                ProdId = product.ProdId,
                ProdName = product.ProdName,
                Brand = product.Brand,
                Price = product.Price,
                Description = product.Description,
                ImageUrl = product.ImageUrl
            };
        }

        public void AddProduct(ProductDTO productDto)
        {
            var product = new Product
            {
                ProdId = productDto.ProdId,
                ProdName = productDto.ProdName,
                Brand = productDto.Brand,
                Price = productDto.Price,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl
            };
            _products.Add(product);
        }

        public void UpdateProduct(ProductDTO productDto)
        {
            var product = _products.FirstOrDefault(p => p.ProdId == productDto.ProdId);
            if (product != null)
            {
                product.ProdName = productDto.ProdName;
                product.Brand = productDto.Brand;
                product.Price = productDto.Price;
                product.Description = productDto.Description;
                product.ImageUrl = productDto.ImageUrl;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProdId == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
