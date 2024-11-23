namespace LoginEficaz.Core.DTOs
{
    public class CreditCardDTO
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVC { get; set; }
        public Guid UserId { get; set; }
    }
}
