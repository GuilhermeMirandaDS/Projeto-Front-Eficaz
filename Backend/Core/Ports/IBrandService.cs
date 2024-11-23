using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface IBrandService
    {
        Task<List<BrandDTO>> GetAllBrands();
        Task<BrandDTO> GetBrandById(int id);
        Task AddBrand(BrandDTO brand);
        Task UpdateBrand(BrandDTO brand);
        Task DeleteBrand(int id);
    }
}
