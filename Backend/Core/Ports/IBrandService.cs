using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IBrandService
    {
        IEnumerable<BrandDTO> GetAllBrands();
        BrandDTO GetBrandById(int id);
        void AddBrand(BrandDTO brand);
        void UpdateBrand(BrandDTO brand);
        void DeleteBrand(int id);
    }
}
