using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Image")]
        public string? imagePath { get; set; }
        [NotMapped]
        public IFormFile? imageFile { get; set; }

        public Product() { }
        public Product(string nvtitle)
        {
            Title = nvtitle;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Product product = (Product)obj;
            if (this.Id == product.Id) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
