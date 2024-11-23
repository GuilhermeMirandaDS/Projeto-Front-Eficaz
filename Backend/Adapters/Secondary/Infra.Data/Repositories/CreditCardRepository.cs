using LoginEficaz.Adapters.Secondary.Infra.Data.Context;
using LoginEficaz.Core.Entities;
using LoginEficaz.Core.Ports;
using Microsoft.EntityFrameworkCore;

namespace LoginEficaz.Adapters.Secondary.Infra.Data.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CreditCardRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RegisterCreditCard(CreditCard creditCard)
        {
            await _dbContext.CreditCards.AddAsync(creditCard);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<CreditCard> GetCreditCardById(int id)
        {
            return await _dbContext.CreditCards.FindAsync(id);
        }

        public async Task<List<CreditCard>> GetCreditCardsByUserId(Guid userId)
        {
            return await _dbContext.CreditCards
                .Where(c => c.UserId == userId)
                .ToListAsync();
        }

        public async Task<bool> UpdateCreditCard(CreditCard updatedCard)
        {
            var existingCard = await _dbContext.CreditCards.FindAsync(updatedCard.Id);
            if (existingCard == null)
            {
                return false;
            }

            _dbContext.Entry(existingCard).CurrentValues.SetValues(updatedCard);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCreditCard(int id)
        {
            var card = await _dbContext.CreditCards.FindAsync(id);
            if (card == null)
            {
                return false;
            }

            _dbContext.CreditCards.Remove(card);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}