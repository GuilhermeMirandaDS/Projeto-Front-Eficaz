using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using Microsoft.EntityFrameworkCore;
using LoginEficaz.Adapters.Secondary.Infra.Data.Context;


namespace LoginEficaz.Adapters.Secondary.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products.Include(p => p.Brand).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dbContext.Products.Include(p => p.Brand).FirstOrDefaultAsync(p => p.ProdId == id);
        }

        public async Task<List<Product>> GetProductsByBrandId(int brandId)
        {
            return await _dbContext.Products.Where(p => p.BrandId == brandId).Include(p => p.Brand).ToListAsync();
        }

        public async Task RegisterProduct(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            var existingProduct = await _dbContext.Products.FindAsync(product.ProdId);
            if (existingProduct == null) throw new KeyNotFoundException("Product not found");

            _dbContext.Entry(existingProduct).CurrentValues.SetValues(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null) throw new KeyNotFoundException("Product not found");

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateImage()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
