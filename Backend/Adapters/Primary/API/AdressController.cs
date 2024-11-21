using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Ports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _service.GetById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(AddressDTO dto)
        {
            _service.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.ZipCode }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AddressDTO dto)
        {
            if (!_service.Update(dto)) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}
