namespace LoginEficaz.Core.DTOs
{
    public class CreditCardDTO
    {
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVC { get; set; }
    }
}
