namespace LoginEficaz.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string? Email { get; set; }
        public bool TermsAgreed { get; set; }
        public string? ImageUrl { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<CreditCard> CreditCards { get; set; } = new List<CreditCard>();
    }
}
