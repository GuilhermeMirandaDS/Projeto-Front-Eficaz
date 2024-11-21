namespace LoginEficaz.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }  
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public User User { get; set; }
    }
}
