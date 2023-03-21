namespace ShoppingCart.Models
{
    public class CartItem : Item
    {
        public int Quantity { get; set; }

        public CartItem(Item item, int qty) : base(item.Code, item.Description, item.Price)
        {
            Quantity = qty;
            
        }
    }
}
