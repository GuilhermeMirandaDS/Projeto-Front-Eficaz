using LoginEficaz.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginEficaz.Core.Ports
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetAllBrands();
        Task<Brand> GetBrandById(int id);
        Task AddBrand(Brand brand);
        Task UpdateBrand(Brand brand);
        Task DeleteBrand(int id);
    }
}