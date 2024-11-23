using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Ports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoginEficaz.Adapters.Primary.API
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardService _service;

        public CreditCardController(ICreditCardService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCreditCardByUserId(Guid userId)
        {
            var result = await _service.GetCreditCardByUser(userId);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterCreditCard(CreditCardDTO dto)
        {
            await _service.RegisterCreditCard(dto);
            return CreatedAtAction(nameof(GetCreditCardByUserId), new { userId = dto.UserId }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCreditCard(int id, CreditCardDTO dto)
        {
            dto.Id = id;
            var updated = await _service.UpdateCreditCard(dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCreditCard(int id)
        {
            var deleted = await _service.DeleteCreditCard(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
