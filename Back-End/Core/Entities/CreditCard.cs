namespace LoginEficaz.Core.Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVC { get; set; }
        public User User { get; set; }
    }
}
