namespace WebApplication2.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<CartItem>? cartItems { get; set; }
        public Cart() { }
    }
}
