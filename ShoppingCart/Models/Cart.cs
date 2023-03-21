namespace ShoppingCart.Models
{
    public class Cart
    {
        private List<CartItem> cartitems;

        public Cart() 
        {
            cartitems = new List<CartItem>();
        }

        public void Add(Item item) 
        {
            CartItem found = cartitems.FirstOrDefault(p=>p.Code.ToLower().Equals(item.Code.ToLower()));
            if (found == null)
            {
                cartitems.Add(new CartItem(item,1));
            }
            else
            {
                found.Quantity++;
            }
        }

        public double CalculateTotalPrice()
        {
            return cartitems.Sum(p => p.Price * p.Quantity);
        }
    }
}
