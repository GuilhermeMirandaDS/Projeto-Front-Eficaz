namespace LoginEficaz.Core.DTOs
{
    public class RegisterUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Gender { get; set; }
        public string CPF { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string SecurityQuestion { get; set; }
        public bool TermsAgreed { get; set; }
    }
}
