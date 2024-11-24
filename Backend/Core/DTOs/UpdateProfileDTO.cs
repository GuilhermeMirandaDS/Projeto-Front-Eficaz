namespace LoginEficaz.Core.DTOs
{
    public class UpdateProfileDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string? ImageUrl { get; set; }
        public List<CreditCardDTO> CreditCards { get; set; } = new List<CreditCardDTO>();
        public List<AddressDTO> Addresses { get; set; } = new List<AddressDTO>();
    }
}
