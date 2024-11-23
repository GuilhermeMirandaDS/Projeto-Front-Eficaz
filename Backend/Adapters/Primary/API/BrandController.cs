using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Ports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace LoginEficaz.Adapters.Primary.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandController(IBrandService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var result = await _service.GetAllBrands();
            if (result == null || result.Count == 0) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var result = await _service.GetBrandById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddBrand(BrandDTO dto)
        {
            await _service.AddBrand(dto);
            return CreatedAtAction(nameof(GetBrandById), new { id = dto.BrandId }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, BrandDTO dto)
        {
            dto.BrandId = id;
            await _service.UpdateBrand(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _service.DeleteBrand(id);
            return NoContent();
        }
    }
}