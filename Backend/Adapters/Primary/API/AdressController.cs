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
    [Authorize]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAddressByUserId(Guid userId)
        {
            var result = await _service.GetAddressByUser(userId);
            if (result == null || result.Count == 0) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAddress(AddressDTO dto)
        {
            await _service.RegisterAddress(dto);
            return CreatedAtAction(nameof(GetAddressByUserId), new { userId = dto.UserId }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(int id, AddressDTO dto)
        {
            dto.Id = id;
            var updated = await _service.UpdateAddress(dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var deleted = await _service.DeleteAddress(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}