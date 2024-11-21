using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;

namespace LoginEficaz.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly List<Brand> _brands = new List<Brand>();

        public IEnumerable<BrandDTO> GetAllBrands()
        {
            return _brands.Select(b => new BrandDTO
            {
                BrandId = b.BrandId,
                BrandName = b.BrandName
            });
        }

        public BrandDTO GetBrandById(int id)
        {
            var brand = _brands.FirstOrDefault(b => b.BrandId == id);
            if (brand == null) return null;

            return new BrandDTO
            {
                BrandId = brand.BrandId,
                BrandName = brand.BrandName
            };
        }

        public void AddBrand(BrandDTO brandDto)
        {
            var brand = new Brand
            {
                BrandId = brandDto.BrandId,
                BrandName = brandDto.BrandName
            };
            _brands.Add(brand);
        }

        public void UpdateBrand(BrandDTO brandDto)
        {
            var brand = _brands.FirstOrDefault(b => b.BrandId == brandDto.BrandId);
            if (brand != null)
            {
                brand.BrandName = brandDto.BrandName;
            }
        }

        public void DeleteBrand(int id)
        {
            var brand = _brands.FirstOrDefault(b => b.BrandId == id);
            if (brand != null)
            {
                _brands.Remove(brand);
            }
        }
    }
}
