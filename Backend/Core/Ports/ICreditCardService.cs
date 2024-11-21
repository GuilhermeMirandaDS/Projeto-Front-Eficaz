using LoginEficaz.Core.DTOs;

namespace LoginEficaz.Core.Ports
{
    public interface ICreditCardService
    {
        IEnumerable<CreditCardDTO> GetAll();
        CreditCardDTO GetById(int id);
        void Create(CreditCardDTO creditCard);
        bool Update(CreditCardDTO creditCard);
        bool Delete(int id);
    }
}
