using LoginEficaz.Core.Entities;

namespace LoginEficaz.Core.DTOs
{
    public class ProductDTO
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string BrandId { get; set; }
        public Brand Brand { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }

    }
}
