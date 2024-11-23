using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;

namespace LoginEficaz.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<BrandDTO>> GetAllBrands()
        {
            var brands = await _brandRepository.GetAllBrands();
            return brands.Select(b => new BrandDTO
            {
                BrandId = b.BrandId,
                BrandName = b.BrandName
            }).ToList();
        }

        public async Task<BrandDTO> GetBrandById(int id)
        {
            var brand = await _brandRepository.GetBrandById(id);
            if (brand == null) throw new KeyNotFoundException("Brand not found");
            return new BrandDTO
            {
                BrandId = brand.BrandId,
                BrandName = brand.BrandName
            };
        }

        public async Task AddBrand(BrandDTO brandDto)
        {
            var brand = new Brand
            {
                BrandName = brandDto.BrandName
            };

            await _brandRepository.AddBrand(brand);
        }

        public async Task UpdateBrand(BrandDTO brandDto)
        {
            var brand = new Brand
            {
                BrandId = brandDto.BrandId,
                BrandName = brandDto.BrandName
            };

            await _brandRepository.UpdateBrand(brand);
        }

        public async Task DeleteBrand(int id)
        {
            await _brandRepository.DeleteBrand(id);
        }
    }
}

