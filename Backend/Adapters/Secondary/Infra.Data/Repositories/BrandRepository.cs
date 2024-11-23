using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using Microsoft.EntityFrameworkCore;
using LoginEficaz.Adapters.Secondary.Infra.Data.Context;


namespace LoginEficaz.Adapters.Secondary.Infra.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BrandRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Brand>> GetAllBrands()
        {
            return await _dbContext.Brands.ToListAsync();
        }

        public async Task<Brand> GetBrandById(int id)
        {
            return await _dbContext.Brands.FindAsync(id);
        }

        public async Task AddBrand(Brand brand)
        {
            await _dbContext.Brands.AddAsync(brand);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBrand(Brand brand)
        {
            var existingBrand = await _dbContext.Brands.FindAsync(brand.BrandId);
            if (existingBrand == null) throw new KeyNotFoundException("Brand not found");

            _dbContext.Entry(existingBrand).CurrentValues.SetValues(brand);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBrand(int id)
        {
            var brand = await _dbContext.Brands.FindAsync(id);
            if (brand == null) throw new KeyNotFoundException("Brand not found");

            _dbContext.Brands.Remove(brand);
            await _dbContext.SaveChangesAsync();
        }
    }
}