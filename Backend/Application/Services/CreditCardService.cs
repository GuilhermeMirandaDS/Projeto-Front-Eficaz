using LoginEficaz.Core.DTOs;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;

namespace LoginEficaz.Application.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly List<CreditCard> _creditCards = new();

        public IEnumerable<CreditCardDTO> GetAll()
        {
            return _creditCards.Select(c => new CreditCardDTO
            {
                CardNumber = c.CardNumber,
                ExpiryDate = c.ExpiryDate,
                CVC = c.CVC
            });
        }

        public CreditCardDTO GetById(int id)
        {
            var creditCard = _creditCards.FirstOrDefault(c => c.Id == id);
            return creditCard == null ? null : new CreditCardDTO
            {
                CardNumber = creditCard.CardNumber,
                ExpiryDate = creditCard.ExpiryDate,
                CVC = creditCard.CVC
            };
        }

        public void Create(CreditCardDTO creditCard)
        {
            _creditCards.Add(new CreditCard
            {
                Id = _creditCards.Count + 1,
                CardNumber = creditCard.CardNumber,
                ExpiryDate = creditCard.ExpiryDate,
                CVC = creditCard.CVC
            });
        }

        public bool Update(CreditCardDTO creditCard)
        {
            var existing = _creditCards.FirstOrDefault(c => c.Id == creditCard.Id);
            if (existing == null) return false;

            existing.CardNumber = creditCard.CardNumber;
            existing.ExpiryDate = creditCard.ExpiryDate;
            existing.CVC = creditCard.CVC;
            return true;
        }

        public bool Delete(int id)
        {
            var creditCard = _creditCards.FirstOrDefault(c => c.Id == id);
            if (creditCard == null) return false;

            _creditCards.Remove(creditCard);
            return true;
        }
    }
}
