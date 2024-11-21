using System.ComponentModel.DataAnnotations;
namespace LoginEficaz.Core.Entities
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }

    }
}
