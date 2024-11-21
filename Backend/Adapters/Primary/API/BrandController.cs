using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Ports;
using Microsoft.AspNetCore.Mvc;

namespace LoginEficaz.Adapters.Primary.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public IActionResult GetAllBrands()
        {
            return Ok(_brandService.GetAllBrands());
        }

        [HttpGet("{id}")]
        public IActionResult GetBrandById(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if (brand == null) return NotFound();
            return Ok(brand);
        }

        [HttpPost]
        public IActionResult AddBrand(BrandDTO brandDto)
        {
            _brandService.AddBrand(brandDto);
            return CreatedAtAction(nameof(GetBrandById), new { id = brandDto.BrandId }, brandDto);
        }

        [HttpPut]
        public IActionResult UpdateBrand(BrandDTO brandDto)
        {
            _brandService.UpdateBrand(brandDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            _brandService.DeleteBrand(id);
            return NoContent();
        }
    }
}
