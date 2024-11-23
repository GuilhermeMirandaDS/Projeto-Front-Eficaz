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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _service.GetAllProducts();
            if (result == null || result.Count == 0) return NotFound();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _service.GetProductById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("brand/{brandId}")]
        public async Task<IActionResult> GetProductsByBrandId(int brandId)
        {
            var result = await _service.GetProductsByBrandId(brandId);
            if (result == null || result.Count == 0) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDTO dto)
        {
            await _service.RegisterProduct(dto);
            return CreatedAtAction(nameof(GetProductById), new { id = dto.ProdId }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductDTO dto)
        {
            dto.ProdId = id;
            await _service.UpdateProduct(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteProduct(id);
            return NoContent();
        }
    }
}
