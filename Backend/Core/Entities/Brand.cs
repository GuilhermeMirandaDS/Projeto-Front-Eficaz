namespace LoginEficaz.Core.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
