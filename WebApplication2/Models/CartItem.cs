using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public int Product_Id { get; set; }
        public Cart? Cart { get; set; }
        public int Cart_Id { get; set; }
        public CartItem() { }
    }
}
