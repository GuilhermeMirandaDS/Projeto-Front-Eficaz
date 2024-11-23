using LoginEficaz.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace LoginEficaz.Core.Ports
{
    public interface ICreditCardRepository
    {
        Task RegisterCreditCard(CreditCard creditCard);
        Task<CreditCard> GetCreditCardById(int id);
        Task<List<CreditCard>> GetCreditCardsByUserId(Guid userId);
        Task<bool> UpdateCreditCard(CreditCard updatedCard);
        Task<bool> DeleteCreditCard(int id);
    }
}
