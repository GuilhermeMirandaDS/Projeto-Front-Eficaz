
using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using LoginEficaz.Adapters.Secondary.Infra.Data.Repositories;

namespace LoginEficaz.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IBrandRepository _brandRepository;

        public ProductService(IProductRepository productRepository, IBrandRepository brandRepository)
        {
            _productRepository = productRepository;
            _brandRepository = brandRepository;
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            return products.Select(p => new ProductDTO
            {
                ProdId = p.ProdId,
                ProdName = p.ProdName,
                Description = p.Description,
                Price = p.Price,
                BrandId = p.BrandId
            }).ToList();
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _productRepository.GetProductById(id);
            if (product == null) throw new KeyNotFoundException("Product not found");
            return new ProductDTO
            {
                ProdId = product.ProdId,
                ProdName = product.ProdName,
                Description = product.Description,
                Price = product.Price,
                BrandId = product.BrandId
            };
        }

        public async Task<List<ProductDTO>> GetProductsByBrandId(int brandId)
        {
            var products = await _productRepository.GetProductsByBrandId(brandId);
            return products.Select(p => new ProductDTO
            {
                ProdId = p.ProdId,
                ProdName = p.ProdName,
                Description = p.Description,
                Price = p.Price,
                BrandId = p.BrandId
            }).ToList();
        }

        public async Task RegisterProduct(ProductDTO productDto)
        {
            var brand = await _brandRepository.GetBrandById(productDto.BrandId);
            if (brand == null) throw new KeyNotFoundException("Brand not found");

            var product = new Product
            {
                ProdName = productDto.ProdName,
                Description = productDto.Description,
                Price = productDto.Price,
                BrandId = productDto.BrandId
            };

            await _productRepository.RegisterProduct(product);
        }

        public async Task UpdateProduct(ProductDTO productDto)
        {
            var product = new Product
            {
                ProdId = productDto.ProdId,
                ProdName = productDto.ProdName,
                Description = productDto.Description,
                Price = productDto.Price,
                BrandId = productDto.BrandId
            };

            await _productRepository.UpdateProduct(product);
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.DeleteProduct(id);
        }
    }
}
