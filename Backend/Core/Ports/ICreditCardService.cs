using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface ICreditCardService
    {
        Task<List<CreditCardDTO>> GetCreditCardByUser(Guid userId);
        Task RegisterCreditCard(CreditCardDTO creditCard);
        Task<bool> UpdateCreditCard(CreditCardDTO creditCard);
        Task<bool> DeleteCreditCard(int id);
    }
}
