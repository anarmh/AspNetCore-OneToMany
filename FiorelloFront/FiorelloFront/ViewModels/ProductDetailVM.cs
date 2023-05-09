using FiorelloFront.Models;

namespace FiorelloFront.ViewModels
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoyName { get; set; }
        public decimal Price { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
