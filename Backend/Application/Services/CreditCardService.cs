using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using LoginEficaz.Adapters.Secondary.Infra.Data.Repositories;

namespace LoginEficaz.Application.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly ICreditCardRepository _creditCardRepository;
        private readonly IUserRepository _userRepository;

        public CreditCardService(ICreditCardRepository creditCardRepository, IUserRepository userRepository)
        {
            _creditCardRepository = creditCardRepository;
            _userRepository = userRepository;
        }

        public async Task<List<CreditCardDTO>> GetCreditCardByUser(Guid userId)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
                throw new KeyNotFoundException("User not found");

            var creditCards = await _creditCardRepository.GetCreditCardsByUserId(userId);
            var creditCardDTOs = creditCards.Select(c => new CreditCardDTO
            {
                Id = c.Id,
                CardNumber = c.CardNumber,
                ExpiryDate = c.ExpiryDate,
                CVC = c.CVC,
                UserId = c.UserId
            }).ToList();

            return creditCardDTOs;
        }

        public async Task RegisterCreditCard(CreditCardDTO creditCardDto)
        {
            var user = await _userRepository.GetUserById(creditCardDto.UserId);
            if (user == null)
                throw new KeyNotFoundException("User not found");

            var creditCard = new CreditCard
            {
                UserId = creditCardDto.UserId,
                CardNumber = creditCardDto.CardNumber,
                ExpiryDate = creditCardDto.ExpiryDate,
                CVC = creditCardDto.CVC
            };

            await _creditCardRepository.RegisterCreditCard(creditCard);
        }

        public async Task<bool> UpdateCreditCard(CreditCardDTO creditCardDto)
        {
            var creditCard = new CreditCard
            {
                Id = creditCardDto.Id,
                UserId = creditCardDto.UserId,
                CardNumber = creditCardDto.CardNumber,
                ExpiryDate = creditCardDto.ExpiryDate,
                CVC = creditCardDto.CVC
            };

            return await _creditCardRepository.UpdateCreditCard(creditCard);
        }

        public async Task<bool> DeleteCreditCard(int id)
        {
            return await _creditCardRepository.DeleteCreditCard(id);
        }
    }
}